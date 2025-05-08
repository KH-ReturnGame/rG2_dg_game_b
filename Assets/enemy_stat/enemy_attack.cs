using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    public int damage = 10;
    public float damage_delay = 1f;
    private float delay;

    void Update()
    {
        delay += Time.deltaTime;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && delay >= damage_delay)
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
            delay = 0f;
            
        }
    }
}    
