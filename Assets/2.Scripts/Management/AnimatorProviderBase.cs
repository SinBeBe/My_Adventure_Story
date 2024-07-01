using UnityEngine;

public abstract class AnimatorProviderBase : MonoBehaviour, IAnimatorProvider
{
    public abstract Animator GetAnimator();
}
