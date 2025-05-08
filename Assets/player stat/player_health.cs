using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int Hp = 100;
    public GameObject dead_text;

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log("현재체력: " + Hp);

        if (Hp<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Time.timeScale = 0;

        dead_text.gameObject.SetActive(true);
    }
}
