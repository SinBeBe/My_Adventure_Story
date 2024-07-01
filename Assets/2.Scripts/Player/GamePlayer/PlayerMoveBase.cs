using UnityEngine;


public abstract class PlayerMoveBase : MonoBehaviour
{
    public abstract void Move(Vector2 moveInput, bool isRun, bool isToggleCameraRotation);
}

public abstract class RigidbodyProviderBase : MonoBehaviour, IRigidbodyProvider
{
    public abstract Rigidbody GetRigidbody();
}
