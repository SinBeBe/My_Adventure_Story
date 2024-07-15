using UnityEngine;

public abstract class CameraBase : MonoBehaviour, ICameraMove, ICursorHandler
{
    public abstract void CameraMove();
    public abstract void LookPlayer();

    public void UpdateCursor(bool value, CursorLockMode mode)
    {
        Cursor.visible = value;
        Cursor.lockState = mode;
    }
}
