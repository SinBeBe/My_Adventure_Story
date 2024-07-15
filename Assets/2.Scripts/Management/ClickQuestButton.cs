using UnityEngine;
using UnityEngine.UI;

enum quest
{
    Accept = 1,
    UnAccept = 2
}

public class ClickQuestButton : ClickButtonBase
{
    [SerializeField]
    private GameObject questUI;
    [SerializeField]
    private QuestContain questContain;

    private string str;
    private Text text;

    public override void ClickButtons(int num)
    {
        questUI.SetActive(false);
        UpdateCursor(false, CursorLockMode.Locked);

        if(num == (int)quest.Accept)
        {
            questContain.StrText(ref str, ref text);
            questContain.StrTextContain(str, ref text);
            Debug.Log("Accept");
        }
        else if(num == (int)quest.UnAccept)
        {
            Debug.Log("UnAccept");
        }
    }
}
