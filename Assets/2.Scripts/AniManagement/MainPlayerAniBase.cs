using UnityEngine;
/// <summary>
/// MainPlayerAniBase�� IMainPlayerAni �������̽��� �����ϴ� �߻�Ŭ�����Դϴ�.
/// </summary>
public abstract class MainPlayerAniBase : MonoBehaviour, IPlayerAni
{
    /// <summary>
    /// �÷��̾��� Idle �ִϸ��̼� ��� �޼����Դϴ�.
    /// </summary>
    public abstract void PlayIdleAni();

    /// <summary>
    /// �ִϸ��̼� ��Ʈ�ѷ��� �������� �޼����Դϴ�.
    /// </summary>

    protected abstract Animator GetAnimator();
}
