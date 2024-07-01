using UnityEngine;

public interface IPlayerMove
{
    void Move();
}

public interface IRigidbodyProvider
{
    Rigidbody GetRigidbody();
}