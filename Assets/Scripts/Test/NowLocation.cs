using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowLocation : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var position = target.transform.position;
        var name = target.name;

        this.GetComponent<Text>().text = name + ": " + position.x + ", " + position.y + ", " + position.z;
	}
}
