using UnityEngine;

public class Test : MonoBehaviour
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
        rb.useGravity = true; // 초기 상태 설정
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

    void Move()
    {
        // WASD 키 입력에 따라 이동 방향 결정
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxisRaw("Horizontal");
        if (moveDirection.sqrMagnitude > 0.01f)
        {
            moveDirection.Normalize();

            // 걷기와 달리기 속도 설정
            float finalSpeed = isRun ? runSpeed : speed;
            rb.MovePosition(transform.position + moveDirection * finalSpeed * Time.deltaTime);

            // 애니메이터 설정
            float percent = (isRun ? 1 : 0.5f) * moveDirection.magnitude;
            animator.SetFloat("Blend", percent, 0.1f, Time.deltaTime);
        }
        else
        {
            // 애니메이터 정지 설정
            animator.SetFloat("Blend", 0, 0.1f, Time.deltaTime);
        }
    }

    void RotateWithCamera()
    {
        Vector3 playerRotate = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1));
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
    }
}
