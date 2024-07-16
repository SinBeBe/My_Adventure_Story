using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ContainBase : MonoBehaviour, IContain
{
    public virtual void IntContain(int get, ref int set)
    {
        set = get;
    }

    public virtual void FloatContain(float get, ref float set)
    {
        set = get;
    }

    public virtual void StringContain(string get, ref string set)
    {
        set = get;
    }

    public virtual void TextContain(Text get, ref Text set)
    {
        set = get;
    }

    public virtual void StrTextContain(string get, ref Text set)
    {
        set.text = get;
    }

    public virtual void ItemContain(ItemData get, ref List<ItemData> set)
    {
        set.Add(get);
    }

    public virtual void SlotContain(SlotBase get, ref List<SlotBase> set)
    {
        set.Add(get);
    }

    public virtual void ItemsContain(List<ItemData> get, ref List<ItemData> set)
    {
        for(int i = 0; i < get.Count; i++)
        {
            set[i] = get[i];
        }
    }

    public virtual void SlotsContain(List<SlotBase> get, ref List<SlotBase> set)
    {
        for (int i = 0; i < get.Count; i++)
        {
            set[i] = get[i];
        }
    }
}
