using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// StageTransitionBase�� IStageTransition �������̽��� �����ϴ� �߻�Ŭ�����Դϴ�.
/// </summary>
public abstract class StageTransitionBase : MonoBehaviour, IStageTransition
{
    /// <summary>
    /// ���� ���������� ��ȯ�ϴ� �޼��带 �����մϴ�.
    /// </summary>
    public abstract void TransitionToNextStage();
    /// <summary>
    /// ��ư Ŭ�� �̺�Ʈ�� ó���մϴ�
    /// </summary>
    protected abstract void OnButtonClick();
}
