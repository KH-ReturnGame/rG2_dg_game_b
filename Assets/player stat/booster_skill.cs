using UnityEngine;

public class booster_skill : MonoBehaviour
{
    public player_movement playerspeed;
    public float boost_time = 3f;
    public float boost_speed = 5f;
    
    private float cooldown;
    private float o_speed; //원래 속도
    private float timer;
    private bool isBoost = false;


    public GameObject boosteffect;

    void Start()
    {
        o_speed = playerspeed.moveSpeed; //처음속도 받기
        cooldown = 1f;
    }
    void Update()
    {
        if (cooldown > 0) //쿨다운 세기
        {
            cooldown -= Time.deltaTime;
        } // 끝

        if (Input.GetKeyDown(KeyCode.R) && cooldown <= 0)
        {
            if (!isBoost) //부스트 아닐 때 키는 기능
            {
                playerspeed.moveSpeed = boost_speed;
                isBoost = true;
                timer = boost_time;
                boosteffect.gameObject.SetActive(true);
            }
        } // 끝

        if (isBoost) // 부스트 켜졌을 때
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                playerspeed.moveSpeed = o_speed;
                isBoost = false;
                cooldown = 7.5f;
                boosteffect.gameObject.SetActive(false);
            }
        } // 끝

        
    }
}
