using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    private Slider sliderUp;
    private Slider sliderTurn;
    private Slider sliderReverse;
    private float levelUp;
    private float levelTurn;
    private float levelReverse;

	// Use this for initialization
	void Start () {
        sliderUp = GameObject.Find("SliderUp").GetComponent<Slider>();
        sliderTurn = GameObject.Find("SliderTurn").GetComponent<Slider>();
        sliderReverse = GameObject.Find("SliderReverse").GetComponent<Slider>();
        sliderUp.value = 0;
        sliderReverse.value = 0;
        sliderTurn.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
        levelUp = sliderUp.value;
        levelTurn = sliderTurn.value;
        levelReverse = sliderReverse.value;
        Vector3 pos = this.transform.localPosition;
        Quaternion rotate = this.transform.localRotation;
        this.gameObject.transform.localPosition = new Vector3(pos.x, levelUp, pos.z);
        //this.gameObject.transform.rotation = Quaternion.Euler(levelReverse, levelTurn, 0); 
        if (this.gameObject.name.Equals("earthN"))
        {
            this.gameObject.transform.rotation = Quaternion.Euler(levelReverse, levelTurn, 0);
        }
        else
        {
            this.gameObject.transform.rotation = Quaternion.Euler(levelReverse + 180, levelTurn, 0);

        }
	}
}
