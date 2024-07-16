using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : PlayerInventoryBase
{
    [SerializeField]
    private GameObject inventoryUI;

    [SerializeField]
    private Inventory inventory;
    private int count = 0;

    private void Update()
    {
        ClickTab();
    }

    public override void ClickTab()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            count++;
            if(count < 2)
            {
                OnOff(inventoryUI, true);
                for(int i = 0; i < FindObjectsOfType<SlotBase>().Length; i++)
                {
                    Debug.Log("Slot");
                    inventory.Slots.Add(FindObjectOfType<SlotBase>());
                }
                UpdateCursor(true, CursorLockMode.None);
            }
            else
            {
                OnOff(inventoryUI, false);
                UpdateCursor(false, CursorLockMode.Locked);
                count = 0;
            }
        }
    }
}
