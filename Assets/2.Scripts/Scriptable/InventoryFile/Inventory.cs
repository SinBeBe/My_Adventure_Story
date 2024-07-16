using System.Collections.Generic;
using UnityEngine;

public class Inventory : InventoryBase
{
    [SerializeField]
    private List<ItemData> items;

    [SerializeField]
    private Transform slotParent;

    private List<SlotBase> slots;

    private void Awake()
    {
        FreshSlot();
    }

    public override void FreshSlot()
    {
        int i = 0;
        for(; i < items.Count && i < slots.Count; i++)
        {
            slots[i].ItemData = items[i];
        }
        for(; i < slots.Count; i++)
        {
            slots[i].ItemData = null;
        }
    }

    public override void AddItem(ItemData itemData)
    {
        if(items.Count < slots.Count)
        {
            items.Add(itemData);
            FreshSlot();
            Debug.Log("Add Item");
        }
        else
        {
            Debug.Log("Max Inventory");
        }
    }

}
