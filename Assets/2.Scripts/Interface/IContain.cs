using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IContain
{
    public void IntContain(int get, ref int set);
    public void FloatContain(float get, ref float set);
    public void StringContain(string get, ref string set);
    public void BoolContain(bool get, ref bool set);
    public void TextContain(Text get, ref Text set);
    public void ItemContain(ItemData get, ref List<ItemData> set);
    public void ItemsContain(List<ItemData> get, ref List<ItemData> set);
    public void SlotContain(SlotBase get, ref List<SlotBase> set);
    public void SlotsContain(List<SlotBase> get, ref List<SlotBase> set);
}
