using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// PlayerMove는 플레이어의 움직임을 구현하는 클래스입니다.
/// </summary>
public class PlayerMove : PlayerMoveBase
{
    private IRigidbodyProvider rigidbodyProvider;
    private PlayerRotationBase playerRotation;
    private Rigidbody rb;
    private Vector2 moveInput;
    private bool isRunning;

    [SerializeField]
    private float walkSpeed = 3f;
    [SerializeField]
    private float runSpeed = 5f;

    private void Awake()
    {
        // IRigidbodyProvider 컴포넌트를 가져옴
        rigidbodyProvider = GetComponent<IRigidbodyProvider>();
        if (rigidbodyProvider == null)
        {
            Debug.LogWarning("IRigidbodyProvider component is missing.");
            return;
        }

        // Rigidbody를 IRigidbodyProvider에서 가져옴
        rb = rigidbodyProvider.GetRigidbody();

        playerRotation = GetComponent<PlayerRotationBase>();
    }

    private void FixedUpdate()
    {
        // 입력 벡터의 크기가 일정 수준 이상일 때만 이동
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
        Vector3 localMovement = new Vector3(moveInput.x, 0, moveInput.y);
        Vector3 globalMovement = transform.TransformDirection(localMovement) * speed;
        rb.velocity = new Vector3(globalMovement.x, rb.velocity.y, globalMovement.z);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        playerRotation.Rotation(moveInput);
    }

    public void OnRun(InputValue value)
    {
        isRunning = value.isPressed;
    }
}
