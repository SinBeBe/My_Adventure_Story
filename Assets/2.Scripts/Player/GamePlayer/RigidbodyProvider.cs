using UnityEngine;

/// <summary>
/// RigidbodyProvider는 RigidbodyProviderBase를 상속받아 Rigidbody를 제공합니다.
/// </summary>
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
