using UnityEngine;

[CreateAssetMenu(fileName = "Villager Data", menuName = "Scriptable Object/Villager Data", order = int.MaxValue)]
public class VillagerData : ScriptableObject
{
    [SerializeField]
    private bool isClear;
    public bool IsClear {  get { return isClear; } }

    [SerializeField]
    private string questText;
    public string QuestText { get { return questText; } }
}
