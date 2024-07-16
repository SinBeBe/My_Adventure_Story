using UnityEngine;
using UnityEngine.UI;

public class SlotBase : MonoBehaviour
{
    [SerializeField]
    private Image image;

    private ItemData itemData;
    public ItemData ItemData
    {
        get { return itemData; }
        set
        {
            itemData = value;
            if (itemData != null)
            {
                image.sprite = ItemData.ItemImage;
            }
        }
    }
}
