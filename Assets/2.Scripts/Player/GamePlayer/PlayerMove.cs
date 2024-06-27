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
            Move(walkSpeed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    public override void Move(float speed)
    {
        // 로컬 방향으로 이동 벡터 계산
        Vector3 localMovement = transform.TransformDirection(new Vector3(moveInput.x, 0, moveInput.y)) * speed;
        rb.velocity = new Vector3(localMovement.x, rb.velocity.y, localMovement.z);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRun(InputValue value)
    {
        if (value.isPressed)
        {
            Move(runSpeed);
        }
    }
}
