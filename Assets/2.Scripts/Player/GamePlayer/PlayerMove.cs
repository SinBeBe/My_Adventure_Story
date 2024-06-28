using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : PlayerMoveBase
{
    private IRigidbodyProvider rigidbodyProvider;
    private Rigidbody rb;
    private Vector2 moveInput;

    [SerializeField]
    private float walkSpeed = 3f;
    [SerializeField]
    private float runSpeed = 5f;
    private bool isRunning = false;

    private void Awake()
    {
        rigidbodyProvider = GetComponent<IRigidbodyProvider>();
        if (rigidbodyProvider == null)
        {
            Debug.LogWarning("IRigidbodyProvider component is missing.");
            return;
        }

        rb = rigidbodyProvider.GetRigidbody();
    }

    private void FixedUpdate()
    {
        if (moveInput.sqrMagnitude > 0.01f)
        {
            float speed = isRunning ? runSpeed : walkSpeed;
            Move(speed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    public override void Move(float speed)
    {
        // 글로벌 방향으로 이동 벡터 계산
        Vector3 globalMovement = new Vector3(moveInput.x, 0, moveInput.y) * speed;
        rb.velocity = new Vector3(globalMovement.x, rb.velocity.y, globalMovement.z);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRun(InputValue value)
    {
        isRunning = value.isPressed;
    }
}