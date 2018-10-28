using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlanet : MonoBehaviour {
    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.gameObject.transform.position = new Vector3(target.transform.localPosition.x, target.transform.position.y, target.transform.position.z + 20);
        //this.gameObject.transform.rotation = new Quaternion(target.transform.rotation.x, target.transform.rotation.y, target.transform.rotation.z, target.transform.rotation.w);
	}
}
