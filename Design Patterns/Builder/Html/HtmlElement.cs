using System;
using System.Text;

namespace Builder.Html;

// Represents an HTML element
public class HtmlElement
{
    private const int indentSize = 2;
    public string TagName { get; set; }
    public string? Text { get; set; }
    public List<HtmlElement> Elements { get; set; }

    public HtmlElement(string tagName, string? text = null)
    {
        TagName = tagName;
        Text = text;
        Elements = [];
    }

    private string ToStringImpl(int indent = 0)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indent * indentSize);
        sb.AppendLine($"{i}<{TagName}>");
        if (!string.IsNullOrEmpty(Text))
        {
            sb.AppendLine(Text);
        }
        foreach (var e in Elements)
        {
            sb.AppendLine(e.ToStringImpl(indent + 1 * indentSize));
        }
        sb.Append($"</{TagName}>");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl();
    }
}
