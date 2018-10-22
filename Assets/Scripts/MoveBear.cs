using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBear : MonoBehaviour {
    private Animator anim;
    private bool isWalking = false;
    private bool isMoveArCamera = false;
    private bool Sit = false;
    private bool rotateFlag = false;
    float speed = 120f;
    float step;
    private bool isFirst = true;
    private GameObject arcamera;
    private Animator aranim;

    public float moveSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        arcamera = GameObject.Find("CameraParent");
	}
	
	// Update is called once per frame
	void Update () {
        if (isWalking == true)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
            anim.SetBool("IsWalk", true);
        }

        if(isMoveArCamera == true) {
            arcamera.transform.Translate(0, 0, moveSpeed * Time.deltaTime * 10);
        }

        if (Input.touchCount > 0)
        {
            //Debug.Log("A-String");
            //anim.SetBool("IsWalk", true);
            //anim.SetBool("IsIdle", false);
            //isWalking = true;

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                // タッチ開始
                isMoveArCamera = true;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // タッチ移動
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // タッチ終了
                isMoveArCamera = false;
                StartCoroutine(DelayMethod());
            }


            if (isFirst)
            {
                isFirst = false;
            } else {
                
            }

        }


        if (Input.GetKeyDown("1"))
        {
            beginWalk();

        }

        if (Input.GetKeyDown("2"))
        {
            stopWalk();

        }

        if (Input.GetKeyDown("3"))
        {
            fall();
        }


        step = speed * Time.deltaTime;
        if(rotateFlag) {
            //指定した方向にゆっくり回転する場合
            //step = speed * Time.deltaTime;
            //transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 0, 90f), step);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, 0, 90f), step);
            anim.SetFloat("MovingSpeed", 0.0f);
        }

	}

    void beginWalk() {
        Debug.Log("A-String");
        anim.SetBool("IsWalk", true);
        anim.SetBool("IsIdle", false);
        isWalking = true;
    }

    void stopWalk() {
        Debug.Log("A-String");
        anim.SetBool("IsWalk", false);
        anim.SetBool("IsIdle", true);
        isWalking = false;
    }

    void fall() {
        Debug.Log("A-String");
        anim.SetBool("IsWalk", false);
        anim.SetBool("IsIdle", false);
        isWalking = false;
        //transform.Rotate(new Vector3(0, 0, 1), -90);
        rotateFlag = true;
    }

    void moveArCamera() {
        isMoveArCamera = true;
    }

    IEnumerator DelayMethod()
    {
        //delay秒待つ
        yield return new WaitForSeconds(7.0f);
        beginWalk();
        yield return new WaitForSeconds(5.0f);
        stopWalk();
        yield return new WaitForSeconds(1.0f);
        fall();
    }
}
