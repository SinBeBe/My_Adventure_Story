using UnityEngine;


public abstract class PlayerMoveBase : MonoBehaviour
{
    public abstract void Move();
}

public abstract class RigidbodyProviderBase : MonoBehaviour, IRigidbodyProvider
{
    public abstract Rigidbody GetRigidbody();
}
