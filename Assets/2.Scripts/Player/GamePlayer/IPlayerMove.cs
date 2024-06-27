using UnityEngine;

/// <summary>
/// IPlayerMove�� �÷��̾��� �������� ����ϴ� �������̽��̴�.
/// </summary>
public interface IPlayerMove
{
    void Move(float speed);
}

public interface IRigidbodyProvider
{
    Rigidbody GetRigidbody();
}