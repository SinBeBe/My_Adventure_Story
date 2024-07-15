using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class QuestContain : ContainBase
{
    [SerializeField]
    private Text playerQuestText;

    private string questStr;

    public void SetVillagerData(VillagerData Data)
    {
        questStr = Data.QuestString;
    }

    public void StrText(ref string str, ref Text text)
    {
        str = questStr;
        text = playerQuestText;
    }

    public override void StrTextContain(string get, ref Text set)
    {
        set.text = "Quest : " + get;
    }
}
