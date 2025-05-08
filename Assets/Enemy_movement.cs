using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
public float speed = 1;
private Transform player;
private SpriteRenderer spriteRenderer;
public float followRange; // 따라오는 최대 거리
    void Start()
    {
        // Player 오브젝트 찾기 (태그 기준)
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position); //위치 계산

            if (followRange > distance)    
            {
                // 플레이어 방향 계산
                Vector2 direction = (player.position - transform.position).normalized;

                // 이동
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

                if (direction.x < 0)
                    spriteRenderer.flipX = true;
                else if (direction.x > 0)
                    spriteRenderer.flipX = false;

                speed += Time.deltaTime/4;
            }
        }
    }
}

