using Unity.VisualScripting;
using UnityEngine;

public class booster : MonoBehaviour
{
    public player_movement playerspeed;
    public float boost_time = 3f;
    public float boost_speed = 5f;
    public float cooldown;

    private float o_speed; //원래 속도
    private float timer;
    private bool isBoost = false;

    void Start()
    {
        o_speed = playerspeed.moveSpeed; //처음속도 받기
    }
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R) && cooldown <= 0)
        {
            if (!isBoost) //부스트 꺼졌을 때 
            {
                playerspeed.moveSpeed = boost_speed;
                isBoost = true;
                timer = boost_time;
            }

        if (isBoost) // 부스트 켜졌을 때
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                playerspeed.moveSpeed = o_speed;
                isBoost = false;
            }
        }
        }
    }
}
