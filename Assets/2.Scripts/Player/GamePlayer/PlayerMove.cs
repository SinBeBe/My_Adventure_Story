using UnityEngine;

public class PlayerMove : PlayerMoveBase
{
    Animator animator;
    Camera cam;
    Rigidbody rb;

    RaycastHit hit;

    private float speed = 2f;
    private float runSpeed = 2.5f;
    private float smoothness = 10f;

    private bool isRun;
    private bool isToggleCameraRotation;

    private void Start()
    {
        animator = GetComponent<Animator>();
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }

    private void Update()
    {
        isToggleCameraRotation = Input.GetKey(KeyCode.LeftAlt);
        isRun = Input.GetKey(KeyCode.LeftShift) && (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0);

        HandleGravity();
        Move();
    }

    private void LateUpdate()
    {
        if (!isToggleCameraRotation)
        {
            RotateWithCamera();
        }
    }

    void HandleGravity()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.1f))
        {
            rb.useGravity = hit.collider == null;
        }
    }

    public override void Move()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxisRaw("Horizontal");
        if (moveDirection.sqrMagnitude > 0.01f)
        {
            moveDirection.Normalize();

            float finalSpeed = isRun ? runSpeed : speed;
            rb.MovePosition(transform.position + moveDirection * finalSpeed * Time.deltaTime);

            float percent = (isRun ? 1 : 0.5f) * moveDirection.magnitude;
            animator.SetFloat("Blend", percent, 0.1f, Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Blend", 0, 0.1f, Time.deltaTime);
        }
    }

    void RotateWithCamera()
    {
        Vector3 playerRotate = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1));
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
    }
}
