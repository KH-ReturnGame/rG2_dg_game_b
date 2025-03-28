using UnityEngine;
using UnityEngine.UI;

public class UIButtonClick : MonoBehaviour
{
    public Button Inventory;
    public GameObject inven;

    void Start()
    {
        Inventory.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("버튼이 클릭되었습니다!");
    }
}
