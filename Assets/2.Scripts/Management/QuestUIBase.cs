using UnityEngine;

public abstract class QuestUIBase : MonoBehaviour, IQuestUI, IOnOff
{
    public abstract void OnOff(GameObject gameobject, bool value);
    public abstract void QuestIcon();
}
