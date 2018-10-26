using UnityEngine;
using System.Collections;

public class TouchHandler : MonoBehaviour
{
    public float distance = 10; // Rayの届く距離

    void Update()
    {
        // タッチされたとき
        if (Input.GetMouseButtonDown(0))
        {
            // メインカメラからクリックしたポジションに向かってRayを撃つ。
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, distance))
            {
                GameObject selectedGameObject = hit.collider.gameObject;
                TapBehaviour target = selectedGameObject.GetComponent(typeof(TapBehaviour)) as TapBehaviour;
                if (target != null)
                {
                    target.TapDown(ref hit);
                }
            }

            // 指を離したとき
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // メインカメラからクリックしたポジションに向かってRayを撃つ。
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, distance))
            {
                GameObject selectedGameObject = hit.collider.gameObject;
                TapBehaviour target = selectedGameObject.GetComponent(typeof(TapBehaviour)) as TapBehaviour;
                if (target != null)
                {
                    target.TapUp(ref hit);
                }
            }

        }
    }
}
