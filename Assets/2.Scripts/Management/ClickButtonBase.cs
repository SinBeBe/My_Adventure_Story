using UnityEngine;

public abstract class ClickButtonBase : MonoBehaviour, IClickButton, ICursorHandler
{
    public abstract void ClickButtons(int num);

    public void UpdateCursor(bool value, CursorLockMode mode)
    {
        Cursor.visible = value;
        Cursor.lockState = mode;
    }
}
