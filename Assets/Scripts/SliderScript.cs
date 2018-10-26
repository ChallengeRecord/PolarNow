using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    private Slider slider;
    private float level;

	// Use this for initialization
	void Start () {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
        level = slider.value;
        Debug.Log(level);
        Vector3 pos = this.transform.localPosition;
        this.gameObject.transform.localPosition = new Vector3(pos.x, level, pos.z);
	}
}
