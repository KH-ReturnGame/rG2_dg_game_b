using UnityEngine;

public class Enable_Check : MonoBehaviour
{
    
    void OnDisable()
    {
        Time.timeScale = 1;
        
    }

    void OnEnable()
    {
        Time.timeScale = 0;
        
    }
}
