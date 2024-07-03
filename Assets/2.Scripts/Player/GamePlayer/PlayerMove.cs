using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : PlayerMoveBase
{
    RaycastHit hit;

    private IAnimatorProvider animatorProvider;
    private IRigidbodyProvider rigidbodyProvider;

    private Animator animator;
    private Rigidbody rb;

    private Vector2 moveInput;

    private Camera cam;

    private float speed = 2f;
    private float runSpeed = 2.5f;
    private float smoothness = 10f;

    private bool isRun;
    private bool isToggleCameraRotation;

    private void Start()
    {
        animatorProvider = GetComponent<IAnimatorProvider>();
        rigidbodyProvider = GetComponent<IRigidbodyProvider>();

        animator = animatorProvider.GetAnimator();
        rb = rigidbodyProvider.GetRigidbody();
        cam = Camera.main;
    }

    private void Update()
    {
        Move();
        HandleGravity();
    }

    private void LateUpdate()
    {
        if (!isToggleCameraRotation)
        {
            RotateWithCamera();
        }
    }

    public override void Move()
    {
        Vector3 forward = transform.TransformDirection(transform.forward);
        Vector3 rigit = transform.TransformDirection(transform.right);

        Vector3 movement = forward * moveInput.x + rigit * moveInput.y;

        if(movement.sqrMagnitude > 0.01f)
        {
            movement.Normalize();

            float finalSpeed = isRun ? runSpeed : speed;
            rb.MovePosition(transform.position + movement * finalSpeed * Time.deltaTime);

            float percent = (isRun ? 1f : 0.5f) * movement.magnitude;
            animator.SetFloat("Blend", percent, 0.1f, Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Blend", 0f, 0.1f, Time.deltaTime);
        }
    }


    void RotateWithCamera()
    {
        Vector3 playerRotate = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1));
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
    }

    void HandleGravity()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.1f))
        {
            rb.useGravity = hit.collider == null;
        }
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRun(InputValue value)
    {
        float runValue = value.Get<float>();
        isRun = runValue > 0 && (moveInput.x != 0 || moveInput.y != 0);
    }
    
    public void OnToggleCameraRotation(InputValue value)
    {
        float toggleValue = value.Get<float>();
        isToggleCameraRotation = toggleValue > 0;
    }
}
