using UnityEngine;

public abstract class PlayerRotationBase : MonoBehaviour, IPlayerRotation
{
    public abstract void Rotation(Vector2 direction);
}
