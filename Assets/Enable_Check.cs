using UnityEngine;

public class Enable_Check : MonoBehaviour
{
    
    void OnDisable()
    {
        Time.timeScale = 1;
        Debug.Log("움직임");
    }

    void OnEnable()
    {
        Time.timeScale = 0;
        Debug.Log("정지");
    }
}
