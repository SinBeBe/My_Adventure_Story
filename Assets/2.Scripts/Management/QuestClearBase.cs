using UnityEngine;

public abstract class QuestClearBase : ContainBase, IClear, IOnOff
{
    public abstract void Clear();
    public void OnOff(GameObject gameObject, bool value)
    {
        gameObject.SetActive(value);
    }
}
