using UnityEngine;

public abstract class CameraBase : MonoBehaviour, IFollow
{
    public abstract void Follow();
    public abstract void LookPlayer();
}
