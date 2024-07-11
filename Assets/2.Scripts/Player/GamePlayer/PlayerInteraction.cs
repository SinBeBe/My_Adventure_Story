using UnityEngine;

public class PlayerInteraction : PlayerInteractionBase
{
    [SerializeField]
    private LayerMask interactLayer;

    [SerializeField]
    private Transform pos;

    private float radius = 3f;

    private void Update()
    {
        Interaction();
    }

    public override void Interaction()
    {
        Collider[] colliders = Physics.OverlapSphere(pos.position, radius, interactLayer);

        foreach (Collider col in colliders)
        {
            Debug.Log("Interaction");
        }
    }
}
