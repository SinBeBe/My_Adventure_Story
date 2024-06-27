using UnityEngine;

/// <summary>
/// AnimatorProvider�� AnimatorProviderBase�� ��ӹ޾� �ִϸ����͸� �����մϴ�.
/// </summary>
public class AnimatorProvider : AnimatorProviderBase
{
    [SerializeField]
    private Animator animator;

    /// <summary>
    /// �ִϸ����͸� �������� �޼����Դϴ�.
    /// </summary>
    public override Animator GetAnimator()
    {
        return animator;
    }
}
