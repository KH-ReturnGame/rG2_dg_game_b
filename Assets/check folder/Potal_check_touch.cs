using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter2D(Collider2D other)
    {    
        if (other.CompareTag("Player"))    
        {
            if (transform.position.y < 2.5 && transform.position.y > 2)
            {
                player.transform.position = new Vector2(0f, 50f);
            }
        }
    }
}
