using System;

namespace SOLID.Interface_Segregation;

public class MultiPrinter : IMachine
{
    public void Fax(Document document)
    {
        //
    }

    public void Print(Document document)
    {
        //
    }

    public void Scan(Document document)
    {
        //
    }

    public void PhotoCopy(Document document)
    {
        //
    }
}

// Good
public class MultiPrinter2 : IPrinter, IScanner, IFax
{
    public void Fax(Document document)
    {
        //
    }

    public void Print(Document document)
    {
        //
    }

    public void Scan(Document document)
    {
        //
    }
}
