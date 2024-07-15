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
}
