using UnityEngine;


/// <summary>
/// PlayerMoveBase�� IPlayerMove �������̽��� �����ϴ� �߻� Ŭ�����Դϴ�.
/// </summary>
public abstract class PlayerMoveBase : MonoBehaviour, IPlayerMove
{
    public abstract void Move(float speed);
}

/// <summary>
/// RigidbodyProviderBase�� IRigidbodyProvider �������̽��� �����ϴ� �߻� Ŭ�����Դϴ�.
/// </summary>
public abstract class RigidbodyProviderBase : MonoBehaviour, IRigidbodyProvider
{
    public abstract Rigidbody GetRigidbody();
}
