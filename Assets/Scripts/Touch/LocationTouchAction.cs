using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTouchAction : TapBehaviour
{
    public override void TapDown(ref RaycastHit hit)
    {
        Debug.Log("タップダウン");
        // タップされたときの処理
    }

    public override void TapUp(ref RaycastHit hit)
    {
        //Debug.Log("タップアップ");
        // タップを離したときの処理
        //string childName = this.gameObject.name;
        //GameObject childObject = this.transform.Find("Location").gameObject;

        var parentTransform = this.transform.parent.gameObject.transform;
        Debug.Log(parentTransform.name);
        int count = 0;

        var transforms = new List<Transform>();

        foreach (Transform child in parentTransform)
        {
            //child is your child transform
            Debug.Log("Child[" + count + "]:" + child.name);
            count++;
            transforms.Add(child);
        }

        StartCoroutine(DelayMethod(transforms));

        //if (activeFlag)
        //{
        //    childObject.SetActive(false);
        //    activeFlag = false;
        //}
        //else {
        //    childObject.SetActive(true);
        //    activeFlag = true;
        //}

    }

    void Update()
    {
        // タップされてるかをフラグで管理したりして適当に更新する。
    }

    IEnumerator DelayMethod(List<Transform> transforms)
    {
        transforms[1].gameObject.SetActive(true);
        //delay秒待つ
        yield return new WaitForSeconds(1.0f);

        for (int i = 2; i < transforms.Count; i++)
        {
            //アタッチするオブジェクトのRendererのComponentを取得する
            Renderer coloring = transforms[i].GetComponent<Renderer>();
            //RendererのMaterialにランダムな色を入れる
            coloring.material.color = new Color(Random.value, Random.value, Random.value, 1.0f); ;
            transforms[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }

    }
}