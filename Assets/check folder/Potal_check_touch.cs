using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position.y < 2.5 && transform.position.y > 2)
        {
            player.transform.position = new Vector2(0f, 13.5f);
        }

        else if (transform.position.y > 12 && transform.position.y < 13)
        {
            player.transform.position = new Vector2(0f, 1.3f);
        }
    }
}
