using UnityEngine;

enum quest
{
    Accept = 1,
    UnAccept = 2
}

public class ClickQuestButton : ClickButtonBase
{
    [SerializeField]
    private GameObject questUI;

    public override void ClickButtons(int num)
    {
        questUI.SetActive(false);
        UpdateCursor(false, CursorLockMode.Locked);

        if(num == (int)quest.Accept)
        {
            
        }
        else if(num == (int)quest.UnAccept)
        {
            
        }
    }
}
