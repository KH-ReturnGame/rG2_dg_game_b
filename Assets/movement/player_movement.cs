using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    private SpriteRenderer spriteRenderer;
    // Update is called once per frame
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
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

        animator.SetFloat("Speed", moveDirection.magnitude);

        if (moveX != 0)
            {
                spriteRenderer.flipX = moveX < 0; // 왼쪽이면 뒤집기
            }
    
    }
}
