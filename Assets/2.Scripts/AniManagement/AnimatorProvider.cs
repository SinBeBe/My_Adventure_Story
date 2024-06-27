using UnityEngine;

/// <summary>
/// AnimatorProvider는 AnimatorProviderBase를 상속받아 애니메이터를 제공합니다.
/// </summary>
public class AnimatorProvider : AnimatorProviderBase
{
    [SerializeField]
    private Animator animator;

    /// <summary>
    /// 애니메이터를 가져오는 메서드입니다.
    /// </summary>
    public override Animator GetAnimator()
    {
        return animator;
    }
}
