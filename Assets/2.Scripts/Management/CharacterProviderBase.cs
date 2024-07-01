using UnityEngine;

public abstract class CharacterProviderBase : MonoBehaviour, ICharacterController
{
    public abstract CharacterController GetCharacterController();
}
