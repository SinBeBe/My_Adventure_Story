using UnityEngine;
public abstract class MainPlayerAniBase : MonoBehaviour, IPlayerAni
{
    public abstract void PlayIdleAni();

    protected abstract Animator GetAnimator();
}
