using UnityEngine;
using TMPro;
public class timer : MonoBehaviour
{
    private float NowTime = 0f;
    public Transform player;
    public float y_position = 10f;
    public TMP_Text timetext;
    void Update()
    {
        if (player.position.y >= y_position)
        {
            NowTime += Time.deltaTime;
        }

        if (timetext != null)
        {
            float seconds = NowTime % 60F;
            int minutes = Mathf.FloorToInt(NowTime / 60F); 
            timetext.text = string.Format("Time: {0:00}:{1:00.00}", minutes, seconds);
        }
    }
}
