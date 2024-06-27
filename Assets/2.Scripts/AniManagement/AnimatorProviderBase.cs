using UnityEngine;

/// <summary>
/// IAnimatorProvider�� �ִϸ����͸� �����ϴ� �������̽��Դϴ�.
/// </summary>
public interface IAnimatorProvider
{
    /// <summary>
    /// �ִϸ����͸� �����ɴϴ�.
    /// </summary>
    Animator GetAnimator();
}

/// <summary>
/// AnimatorProviderBase�� IAnimatorProvider �������̽��� �����ϴ� �߻� Ŭ�����Դϴ�.
/// </summary>
public abstract class AnimatorProviderBase : MonoBehaviour
{
    /// <summary>
    /// �ִϸ����͸� �������� �޼����Դϴ�.
    /// </summary>
    public abstract Animator GetAnimator();
}
