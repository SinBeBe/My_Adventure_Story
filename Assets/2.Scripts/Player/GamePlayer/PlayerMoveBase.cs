using UnityEngine;


/// <summary>
/// PlayerMoveBase는 IPlayerMove 인터페이스를 구현하는 추상 클래스입니다.
/// </summary>
public abstract class PlayerMoveBase : MonoBehaviour, IPlayerMove
{
    public abstract void Move(float speed);
}

/// <summary>
/// RigidbodyProviderBase는 IRigidbodyProvider 인터페이스를 구현하는 추상 클래스입니다.
/// </summary>
public abstract class RigidbodyProviderBase : MonoBehaviour, IRigidbodyProvider
{
    public abstract Rigidbody GetRigidbody();
}
