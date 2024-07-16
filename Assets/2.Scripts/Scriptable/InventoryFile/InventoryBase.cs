using UnityEngine;

public abstract class InventoryBase : MonoBehaviour, IFreshSlot, IAddItem
{
    public abstract void FreshSlot();
    public abstract void AddItem(ItemData itemData);
}
