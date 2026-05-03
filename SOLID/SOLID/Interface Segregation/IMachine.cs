using System;
using System.Dynamic;
using System.Reflection.Metadata;

namespace SOLID.Interface_Segregation;

// BAD!
// Machine can be a printer, a scanner, anything
// Printer is a machine but it's limited to printing
// If a printer implements IMachine, What do we do with the other methods that a printer doesn't do?
// Problem: We Have too many methods in the interface
public class Document { };

// YAGNI - You Aren't Going to Need It
public interface IMachine
{
    void Print(Document document);
    void Scan(Document document);
    void Fax(Document document);
    void PhotoCopy(Document document);

    // void Heat();
    // void Cool();
    // void Copy();
}

// Interface Segregation
public interface IPrinter
{
    void Print(Document document);
}

public interface IScanner
{
    void Scan(Document document);
}

public interface IFax
{
    void Fax(Document document);
}
