using UnityEngine;

/// <summary>
/// IAnimatorProvider는 애니메이터를 제공하는 인터페이스입니다.
/// </summary>
public interface IAnimatorProvider
{
    /// <summary>
    /// 애니메이터를 가져옵니다.
    /// </summary>
    Animator GetAnimator();
}

/// <summary>
/// AnimatorProviderBase는 IAnimatorProvider 인터페이스를 구현하는 추상 클래스입니다.
/// </summary>
public abstract class AnimatorProviderBase : MonoBehaviour
{
    /// <summary>
    /// 애니메이터를 가져오는 메서드입니다.
    /// </summary>
    public abstract Animator GetAnimator();
}
