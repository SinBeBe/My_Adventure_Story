using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Villager : VillagerBase
{
    [SerializeField]
    private LayerMask interactLayer;
    [SerializeField]
    private Transform pos;

    [SerializeField]
    private GameObject questGameObject;
    [SerializeField]
    private GameObject questUI;

    [SerializeField]
    private Text questText;
    [SerializeField]
    private Text rewardText;

    [SerializeField]
    private VillagerData villagerData;
    
    public VillagerData VillagerData { set { villagerData = value; } }

    [SerializeField]
    private QuestContain questContain;

    private float radius = 3f;

    private void Update()
    {
        if(!villagerData.IsClear)
        {
            Interaction();
        }
        OnOff(questGameObject, !villagerData.IsClear);
    }

    public override void Interaction()
    {
        Collider[] colliders = Physics.OverlapSphere(pos.position, radius, interactLayer);
        foreach(Collider collider in colliders)
        {
            Debug.Log("Interaction");
            if (Input.GetKey(KeyCode.F))
            {
                questText.text = "Quest : " + villagerData.QuestString;
                rewardText.text = "Reward : " + villagerData.RewradString;

                UpdateCursor(true, CursorLockMode.None);
                questContain.SetVillagerData(villagerData);
                
                OnOff(questUI, true);
            }
        }
    }

    public override void OnOff(GameObject gameObject, bool value)
    {
        gameObject.SetActive(value);
    }
}
