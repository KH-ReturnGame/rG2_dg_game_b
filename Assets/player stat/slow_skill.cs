using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public float slowFactor;  // 50% 느리게 만들기
    private float cooldown = 10f;
    private float timer;
    private bool effect;
    public GameObject sloweffect;
    public Transform player;

    void Start()
    {
        cooldown = 1f;
    }
    void Update()
    {

        cooldown -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E) && cooldown <= 0 && player.position.y > 10)
        {

            Debug.Log("E 키 누름 - 적 영구 감속!");
            cooldown = 16f;

            GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject obj in enemyObjects)
            {
                Enemy_movement enemy = obj.GetComponent<Enemy_movement>();
                if (enemy != null)
                {
                    enemy.speed *= slowFactor;
                }
            }

             if (!effect)
            {
                sloweffect.gameObject.SetActive(true);
                effect = true;
                timer = 3f;
            }
        } //끝

       
        
        if (effect)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                sloweffect.gameObject.SetActive(false);
                effect = false;
            }
        }
    }
}