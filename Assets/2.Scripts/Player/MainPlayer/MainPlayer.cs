using UnityEngine;

/// <summary>
/// MainPlayerAni�� MainPlayerAniBase�� ��ӹ޾� ����ȭ�鿡�� �÷��̾��� Idle �ִϸ��̼��� ����մϴ�.
/// </summary>
public class MainPlayer : MainPlayerAniBase
{
    private IAnimatorProvider animatorProvider;

    private void Update()
    {
        PlayIdleAni();
    }

    /// <summary>
    /// �÷��̾��� Idle �ִϸ��̼� ��� �޼����Դϴ�.
    /// </summary>
    public override void PlayIdleAni()
    {
        Animator animator = GetAnimator();
        if (animator != null)
        {
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            if (!stateInfo.IsName("Idle"))
            {
                animator.Play("Idle");
            }
        }
        else
        {
            Debug.LogWarning("Animator is not assigned.");
        }
    }

    /// <summary>
    /// �ִϸ��̼� ��Ʈ�ѷ��� �������� �޼����Դϴ�.
    /// </summary>
    protected override Animator GetAnimator()
    {
        if(animatorProvider == null)
        {
            animatorProvider = GetComponent<IAnimatorProvider>();
        }

        return animatorProvider?.GetAnimator();
    }
}
