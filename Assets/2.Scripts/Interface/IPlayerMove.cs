using UnityEngine;

/// <summary>
/// IPlayerMove는 플레이어의 움직임을 담당하는 인터페이스이다.
/// </summary>
public interface IPlayerMove
{
    void Move(float speed);
}

public interface IRigidbodyProvider
{
    Rigidbody GetRigidbody();
}