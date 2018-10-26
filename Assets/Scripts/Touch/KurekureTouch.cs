using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KurekureTouch : TapBehaviour
{
    public override void TapDown(ref RaycastHit hit)
    {
        Debug.Log("タップダウン");
        // タップされたときの処理
    }

    public override void TapUp(ref RaycastHit hit)
    {
        Debug.Log("タップアップ");
        // タップを離したときの処理
    }

    void Update()
    {
        // タップされてるかをフラグで管理したりして適当に更新する。
    }
}