using UnityEngine;

public class CharacterProvider : CharacterProviderBase
{
    [SerializeField]
    CharacterController controller;

    public override CharacterController GetCharacterController()
    {
        return controller;
    }
}
