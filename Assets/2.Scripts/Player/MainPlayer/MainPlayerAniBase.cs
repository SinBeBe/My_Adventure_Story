using UnityEngine;
public abstract class MainPlayerAniBase : MonoBehaviour, ICharacterAni
{
    public abstract void PlayIdleAni();

    protected abstract Animator GetAnimator();
}
