using UnityEngine;

/// <summary>
/// PlayerRotation�� �÷��̾��� ȸ���� �����ϴ� Ŭ�����Դϴ�.
/// </summary>
public class PlayerRotation : PlayerRotationBase
{
    [SerializeField]
    private float rotateSpeed = 10f;

    public override void Rotation(Vector2 moveInput)
    {
        if (moveInput.sqrMagnitude > 0.01f)
        {
            Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        }
    }
}
