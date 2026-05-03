using System;

namespace SOLID.Liskov_Substitution;

// Square is-a Rectangle
public class Square : Rectangle
{
    public int Width
    {
        set { base.Width = base.Height = value; }
    }
    public int Height
    {
        set { base.Width = base.Height = value; }
    }
}
