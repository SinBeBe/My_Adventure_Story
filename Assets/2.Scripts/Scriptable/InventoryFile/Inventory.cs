using System.Collections.Generic;
using UnityEngine;

public class Inventory : InventoryBase
{
    [SerializeField]
    private Transform slotParent;

    [SerializeField]
    private List<ItemData> items;
    public List<ItemData> Items { get { return items; } }
    [SerializeField]
    private List<SlotBase> slots;
    public List<SlotBase> Slots { get { return slots; } }

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
