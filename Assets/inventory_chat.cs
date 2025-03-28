using UnityEngine;


public class Inventory : MonoBehaviour
{
    public GameObject Inventory_UI;
    int setting = 0;
    
    void Start()
    {
        Inventory_UI.SetActive(false);
    }
    void Open()
    {
        Debug.Log("open");
        Inventory_UI.SetActive(true);
    }

    void Close()
    {
        Debug.Log("close");
        Inventory_UI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (setting==0)
            {
                Close();
                setting = 1;
            }

            else
            {
                Open();
                setting = 0;
            }

    }
}