using System;
using Pages = System.Collections.Generic.List<string>;

namespace SOLID;

// SRP -> A Class Should Have One Reason Only To Change. (Separation Of Concerns)
// So, This book's reason to change: "I want to change how a book is represented"
// In the bad Example: You have one more: "I changed the Saving system"
// That is two reasons now - The more you have the worst it gets
// In short, You ask yourself why do I want to change this class? You have more than one answer? That class is violating SRP and it's doing so much

// This book should be Added to, Removed from, Edited in some way
public class Book
{
    Pages m_pages;
    int count;

    public Book()
    {
        m_pages = [];
        count = 1;
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, m_pages);
    }

    public void AddPage(string text)
    {
        m_pages.Add($"Page {count++}:" + text);
    }

    public void RemovePage(int pageNumber)
    {
        m_pages.RemoveAt(pageNumber);
    }

    // Some More Book Related Stuff Here...

    // BAD!
    // Saving to a file
    public void SaveToFile(string FileName, bool overwrite = false)
    {
        if (!File.Exists(FileName) || overwrite)
            File.WriteAllText(FileName, ToString());
    }

    // Save as PDF, As TXT, As JSON

    // Reading it from a file
    public void ReadFromFile(string FileName)
    {
        // ..
    }
    // Sending the book to mars
    // Making the book run the program
    // Telling the book to give us some kind of object
    // In short, These things are not related to the book class
    // And it's not the book responsibility to do
    // So, We minimize the responsibility for each class as much as possible
}
