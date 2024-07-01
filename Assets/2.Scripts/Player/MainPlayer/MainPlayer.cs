using UnityEngine;


public class MainPlayer : MainPlayerAniBase
{
    private IAnimatorProvider animatorProvider;

    private void Update()
    {
        PlayIdleAni();
    }

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


    protected override Animator GetAnimator()
    {
        if(animatorProvider == null)
        {
            animatorProvider = GetComponent<IAnimatorProvider>();
        }

        return animatorProvider?.GetAnimator();
    }
}
