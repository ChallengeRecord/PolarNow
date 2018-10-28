using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthPositioner : MonoBehaviour {

    public GameObject camera;
    public GameObject north;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var southPosition = -1 * (north.transform.position - camera.transform.position);
        southPosition = new Vector3(southPosition.x, north.transform.position.y, southPosition.z);
        this.transform.position = southPosition;
    }
}
