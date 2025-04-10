using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        // 키 입력을 직접 감지하여 즉각적인 반응
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;
        if (Input.GetKey(KeyCode.W)) moveY = 1f;
        if (Input.GetKey(KeyCode.S)) moveY = -1f;
        

        Vector3 moveDirection = new Vector3(moveX, moveY, 0f).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

         if (moveDirection.magnitude > 0)
        {
            if (!animator.enabled)
                animator.enabled = true; // 움직이면 Animator 켜기
        }
        else
        {
            if (animator.enabled)
                animator.enabled = false; // 멈추면 Animator 끄기
        }
    
    }
}
