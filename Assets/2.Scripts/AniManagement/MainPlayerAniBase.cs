using UnityEngine;
/// <summary>
/// MainPlayerAniBase는 IMainPlayerAni 인터페이스를 구현하는 추상클래스입니다.
/// </summary>
public abstract class MainPlayerAniBase : MonoBehaviour, IMainPlayerAni
{
    /// <summary>
    /// 플레이어의 Idle 애니메이션 재생 메서드입니다.
    /// </summary>
    public abstract void PlayIdleAni();

    /// <summary>
    /// 애니메이션 컨트롤러를 가져오는 메서드입니다.
    /// </summary>

    protected abstract Animator GetAnimator();
}
