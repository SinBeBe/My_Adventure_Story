using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : PlayerMoveBase
{
    private IAnimatorProvider animatorProvider;
    private ICharacterController characterControllerProvider;
    private Animator animator;
    private Camera cam;
    private CharacterController characterController;

    private float speed = 2f;
    private float runSpeed = 4f;
    private float smoothness = 10f;

    private Vector2 moveInput;
    private bool isRun;
    private bool isToggleCameraRotation;

    private void Awake()
    {
        animatorProvider = GetComponent<IAnimatorProvider>();
        characterControllerProvider = GetComponent<ICharacterController>();
        animator = animatorProvider.GetAnimator();
        cam = Camera.main;
        characterController = characterControllerProvider.GetCharacterController();
    }

    private void Update()
    {
        if (moveInput.sqrMagnitude > 0.01f)
        {
            Move(moveInput, isRun, isToggleCameraRotation);
        }
    }

    public override void Move(Vector2 moveInput, bool isRun, bool isToggleCameraRotation)
    {
        float finalSpeed = isRun ? runSpeed : speed;

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * moveInput.y + right * moveInput.x;
        characterController.Move(moveDirection * finalSpeed * Time.deltaTime);

        float percent = (isRun ? 1 : 0.5f) * moveDirection.magnitude;
        animator.SetFloat("Blend", percent, 0.1f, Time.deltaTime);

        Vector3 playerRotate = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1));
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        isRun = context.ReadValueAsButton();
    }
}
