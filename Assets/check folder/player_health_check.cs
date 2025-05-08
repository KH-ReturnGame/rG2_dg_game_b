using UnityEngine;
using TMPro;

public class player_health_check : MonoBehaviour
{
    public TMP_Text Text_Hp;
    public PlayerHealth playerHealth;
   

    // Update is called once per frame
    void Update()
    {
         if (playerHealth != null)
        {
            Text_Hp.text = string.Format("Hp: {0}", playerHealth.Hp);
        }
    }
}
