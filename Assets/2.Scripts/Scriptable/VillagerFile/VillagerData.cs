using UnityEngine;

[CreateAssetMenu(fileName = "Villager Data", menuName = "Scriptable Object/Villager Data", order = int.MaxValue)]
public class VillagerData : ScriptableObject
{
    [SerializeField]
    private bool isClear;
    public bool IsClear {  get { return isClear; } set { IsClear = value; } }

    [SerializeField]
    private string questString;
    public string QuestString { get { return questString; } }

    [SerializeField]
    private string rewradString;
    public string RewradString { get {return rewradString; } }
}
