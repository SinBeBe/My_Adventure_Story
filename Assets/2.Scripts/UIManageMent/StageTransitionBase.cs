using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// StageTransitionBase는 IStageTransition 인터페이스를 구현하는 추상클래스입니다.
/// </summary>
public abstract class StageTransitionBase : MonoBehaviour, IStageTransition
{
    /// <summary>
    /// 다음 스테이지로 전환하는 메서드를 구현합니다.
    /// </summary>
    public abstract void TransitionToNextStage();
    /// <summary>
    /// 버튼 클릭 이벤트를 처리합니다
    /// </summary>
    protected abstract void OnButtonClick();
}
