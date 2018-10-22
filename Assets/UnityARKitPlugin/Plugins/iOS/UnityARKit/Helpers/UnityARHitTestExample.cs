using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace UnityEngine.XR.iOS
{
    public class UnityARHitTestExample : MonoBehaviour
    {
        //public変数として、Camera型の変数Camを宣言する
        public Camera cam;

        private Animator anim;
        //private bool isWalking = false;
        //private bool Sit = false;
        //private bool rotateFlag = false;
        //float speed = 120f;
        float step;
        public float moveSpeed = 2f;
        private bool isMoveArCamera = false;
        private bool isFirst = true;
        private GameObject arcamera;
        private Animator aranim;


        // 回り込み対応書きかけ
        //void Start()
        //{
        //    anim = GetComponent<Animator>();
        //    arcamera = GameObject.Find("CameraParent");
        //}

        void Update()
        {

        // 回り込み対応のための書きかけ
        //if (isWalking == true)
        //{
        //    transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        //    anim.SetBool("IsWalk", true);
        //}

        //if(isMoveArCamera == true) {
        //    arcamera.transform.Translate(0, 0, moveSpeed * Time.deltaTime * 10);
        //}

        //if (Input.touchCount > 0)
        //{
        //    //Debug.Log("A-String");
        //    //anim.SetBool("IsWalk", true);
        //    //anim.SetBool("IsIdle", false);
        //    //isWalking = true;

        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        // タッチ開始
        //        isMoveArCamera = true;
        //    }
        //    else if (touch.phase == TouchPhase.Moved)
        //    {
        //        // タッチ移動
        //    }
        //    else if (touch.phase == TouchPhase.Ended)
        //    {
        //        // タッチ終了
        //        isMoveArCamera = false;
        //        StartCoroutine(DelayMethod());
        //    }


        //    if (isFirst)
        //    {
        //        isFirst = false;
        //    } else {
                
        //    }

        //}


        //if (Input.GetKeyDown("1"))
        //{
        //    beginWalk();

        //}

        //if (Input.GetKeyDown("2"))
        //{
        //    stopWalk();

        //}

        //if (Input.GetKeyDown("3"))
        //{
        //    fall();
        //}


        //step = speed * Time.deltaTime;
        //if(rotateFlag) {
        //    //指定した方向にゆっくり回転する場合
        //    //step = speed * Time.deltaTime;
        //    //transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 0, 90f), step);
        //    transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, 0, 90f), step);
        //    anim.SetFloat("MovingSpeed", 0.0f);
        //}




            // サンプルコード
            //if (Input.touchCount > 0 && cam != null) {
            //    SceneManager.LoadScene ("Scenes/hackathon");
            //}


            //if (Input.touchCount > 0 && cam != null)
            //{
                ////CreatePrimitiveで動的にGameObjectであるCubeを生成する
                //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                ////Cubeに適用するランダムな色を生成する
                //Material material = new Material(Shader.Find("Diffuse"))
                //{
                //    color = new Color(Random.value, Random.value, Random.value)
                //};
                ////ランダムに変化する色をCubeに適用する
                //cube.GetComponent<Renderer>().material = material;
                ////Android端末をタップして、ランダムな色のCubeを認識した平面上に投げ出すように追加していく
                ////Cubeの大きさも0.2fとして指定している
                //cube.transform.position = cam.transform.TransformPoint(0, 0, 0.5f);
                //cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                ////CubeにはRigidbodyを持たせて重力を与えておかないと、床の上には配置されないので注意が必要。Rigidbodyで重力を持たせないとCubeは宙に浮いた状態になる
                //cube.AddComponent<Rigidbody>();
                //cube.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0, 1f, 2f), ForceMode.Impulse);
            //}

        }


        // 回り込み対応のための書きかけ
        //void beginWalk()
        //{
        //    Debug.Log("A-String");
        //    anim.SetBool("IsWalk", true);
        //    anim.SetBool("IsIdle", false);
        //    isWalking = true;
        //}

        //void stopWalk()
        //{
        //    Debug.Log("A-String");
        //    anim.SetBool("IsWalk", false);
        //    anim.SetBool("IsIdle", true);
        //    isWalking = false;
        //}

        //void fall()
        //{
        //    Debug.Log("A-String");
        //    anim.SetBool("IsWalk", false);
        //    anim.SetBool("IsIdle", false);
        //    isWalking = false;
        //    //transform.Rotate(new Vector3(0, 0, 1), -90);
        //    rotateFlag = true;
        //}

        //IEnumerator DelayMethod()
        //{
        //    //delay秒待つ
        //    yield return new WaitForSeconds(1.0f);
        //    beginWalk();
        //    yield return new WaitForSeconds(4.0f);
        //    stopWalk();
        //    yield return new WaitForSeconds(1.0f);
        //    fall();
        //}
    }
}