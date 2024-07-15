using UnityEngine;
using UnityEngine.UI;

public interface IContain
{
    public void IntContain(int get, ref int set);
    public void FloatContain(float get, ref float set);
    public void StringContain(string get, ref string set);
    public void TextContain(Text get, ref Text set);
}
