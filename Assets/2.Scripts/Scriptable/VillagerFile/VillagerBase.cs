using UnityEngine;

public abstract class VillagerBase : MonoBehaviour, IInteraction, IOnOff
{
    public abstract void Interaction();

    public abstract void OnOff(GameObject gameObject, bool value);
}
