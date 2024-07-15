using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item Data", order = int.MaxValue)]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } }

    [SerializeField]
    private Sprite itemImage;
    public Sprite ItemImage { get { return itemImage; } }

}
