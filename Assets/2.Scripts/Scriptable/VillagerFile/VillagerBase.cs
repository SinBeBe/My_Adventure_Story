using UnityEngine;

public abstract class VillagerBase : MonoBehaviour, IInteraction, IOnOff, ICursorHandler
{
    public abstract void Interaction();

    public abstract void OnOff(GameObject gameObject, bool value);

    public void UpdateCursor(bool value, CursorLockMode mode)
    {
        Cursor.visible = value;
        Cursor.lockState = mode;
    }
}
