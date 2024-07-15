using UnityEngine;
using UnityEngine.UI;

public class QuestContain : ContainBase
{
    [SerializeField]
    private Text questText;
    [SerializeField]
    private Text playerQuestText;

    public override void TextContain(Text get, ref Text set)
    {
        base.TextContain(get, ref set);
    }
}
