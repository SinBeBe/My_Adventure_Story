using UnityEngine;

/// <summary>
/// MainPlayerAni는 MainPlayerAniBase를 상속받아 메인화면에서 플레이어의 Idle 애니메이션을 재생합니다.
/// </summary>
public class MainPlayer : MainPlayerAniBase
{
    private IAnimatorProvider animatorProvider;

    private void Update()
    {
        PlayIdleAni();
    }

    /// <summary>
    /// 플레이어의 Idle 애니메이션 재생 메서드입니다.
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
    /// 애니메이션 컨트롤러를 가져오는 메서드입니다.
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
