using UnityEngine;

public class RigidbodyProvider : RigidbodyProviderBase
{
    [SerializeField]
    private Rigidbody rb;

    private void Awake()
    {
        if(rb == null)
        {
            var provider = GetComponent<IRigidbodyProvider>();
            if(provider != null && provider is RigidbodyProvider rigidbodyProvider)
            {
                rb = rigidbodyProvider.GetRigidbody();
            }
        }
    }

    public override Rigidbody GetRigidbody()
    {
        return rb;
    }
}
