using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x + Input.GetAxis("Horizontal"),
            gameObject.transform.localScale.y + Input.GetAxis("Vertical"),
            gameObject.transform.localScale.z
        );
        if (Input.GetButton("Fire1"))
        {
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z + 0.5f
            );
        }
        if (Input.GetButton("Fire2"))
        {
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x,
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z - 0.5f
            );
        }
		
	}
}
