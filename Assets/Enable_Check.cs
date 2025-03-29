using UnityEngine;

public class Enable_Check : MonoBehaviour
{
    public GameObject Inventory_UI;
    public GameObject player;
    void OnDisable()
    {
        player.GetComponent<player_movement>().enabled = false;
        Debug.Log("이동 불가");
        
    }

    void OnEnable()
    {
        player.GetComponent<player_movement>().enabled = true;
        Debug.Log("이동 가능능");
        
    }
}
