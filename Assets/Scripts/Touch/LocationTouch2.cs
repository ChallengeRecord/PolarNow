﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTouch2 : TapBehaviour
{
    bool activeFlag = false;

    public override void TapDown(ref RaycastHit hit)
    {
        Debug.Log("タップダウン");
        // タップされたときの処理
    }

    public override void TapUp(ref RaycastHit hit)
    {
        Debug.Log("タップアップ");
        // タップを離したときの処理
        string childName = this.gameObject.name;
        GameObject childObject = this.transform.Find("Location").gameObject;
        if (activeFlag)
        {
            childObject.SetActive(false);
            activeFlag = false;
        }
        else {
            childObject.SetActive(true);
            activeFlag = true;


        }

    }

    void Update()
    {
        // タップされてるかをフラグで管理したりして適当に更新する。
    }
}