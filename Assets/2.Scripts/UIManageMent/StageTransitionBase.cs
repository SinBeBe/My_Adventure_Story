using UnityEngine;
using UnityEngine.Events;

public abstract class StageTransitionBase : MonoBehaviour, IStageTransition
{
    public abstract void TransitionToNextStage();
    protected abstract void OnButtonClick();
}
