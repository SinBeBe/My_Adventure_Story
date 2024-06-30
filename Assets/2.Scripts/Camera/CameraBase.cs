using UnityEngine;

public abstract class CameraBase : MonoBehaviour, ICameraMove
{
    public abstract void CameraMove();
    public abstract void LookPlayer();
}
