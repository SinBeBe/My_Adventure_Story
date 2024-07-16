using UnityEngine;

public abstract class PlayerInventoryBase : ContainBase, IOnOff, ICursorHandler
{
    public abstract void ClickTab();

    public void OnOff(GameObject gameobject, bool value)
    {
        gameobject.SetActive(value);
    }

    public void UpdateCursor(bool value, CursorLockMode mode)
    {
        Cursor.visible = value;
        Cursor.lockState = mode;
    }
}
