using UnityEngine;
using UnityEngine.Events;

public abstract class StageTransitionBase : MonoBehaviour, IStageTransition, IOnOff
{
    public abstract void OnOff(GameObject gameObject, bool value);
    public abstract void TransitionToNextStage();
    protected abstract void OnButtonClick();
}
