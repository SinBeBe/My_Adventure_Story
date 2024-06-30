using UnityEngine;

/// <summary>
/// IStageTransition 인터페이스는 스테이지 전환 동작을 정의합니다.
/// </summary>
public interface IStageTransition
{
    ///<summary>
    /// 다음 스테이지로 전환함.
    /// </summary>

    void TransitionToNextStage();
}
