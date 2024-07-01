using UnityEngine;

public class AnimatorProvider : AnimatorProviderBase
{
    [SerializeField]
    private Animator animator;

    public override Animator GetAnimator()
    {
        return animator;
    }
}
