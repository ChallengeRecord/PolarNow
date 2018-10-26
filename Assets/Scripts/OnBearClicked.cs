using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBearClicked : MonoBehaviour {

    public void OnClick() {
        Debug.Log("クリックされました");

        this.transform.position += new Vector3(5, 0, 0);

    }
}
