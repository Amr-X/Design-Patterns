using System;

namespace Builder.Html;

public class HtmlBuilder
{
    private HtmlElement tagRoot;

    public HtmlBuilder(string tagName)
    {
        tagRoot = new HtmlElement(tagName);
    }

    public void AddElement(string tagName, string? text = null)
    {
        var e = new HtmlElement(tagName, text);
        tagRoot.Elements.Add(e);
    }

    public override string ToString()
    {
        return tagRoot.ToString();
    }
}
