using System;

namespace SOLID.Interface_Segregation;

// BAD!
public class Printer : IMachine
{
    public void Print(Document document)
    {
        //
    }

    // What do you do with these methods?
    public void Scan(Document document)
    {
        throw new NotImplementedException();
    }

    public void Fax(Document document)
    {
        throw new NotImplementedException();
    }

    public void PhotoCopy(Document document)
    {
        throw new NotImplementedException();
    }
}

// Good
public class Printer2 : IPrinter
{
    public void Print(Document document)
    {
        //
    }
}
