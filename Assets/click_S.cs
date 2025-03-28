using UnityEngine;

public class ClickRaycast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 왼쪽 버튼 클릭
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name + "이(가) 클릭되었습니다!");
            }
        }
    }
}
