namespace Singleton.Ambient_Context;

public class ProcessorContext
{
    public static string PersonName { get; set; }
    //.. More 

    public ProcessorContext(string personName)
    {
        PersonName = personName;
    }
}

public class ProcessorContextStack : IDisposable
{
    private static Stack<ProcessorContextStack> _processorContexts = new();

    static ProcessorContextStack()
    {
        _processorContexts.Push(new ProcessorContextStack("Default"));
    }

    public static ProcessorContextStack Current => _processorContexts.Peek();

    public string PersonName { get; set; }
    //.. More 

    public ProcessorContextStack(string personName)
    {
        PersonName = personName;

        _processorContexts.Push(this); // We Save every Context Ref
    }


    public void Dispose()
    {
        // Shouldn't remove the first context
        if (_processorContexts.Count > 1)
        {
            _processorContexts.Pop();
        }
    }
}

public class Processor
{
    public void DoWork()
    {
        DoWork1();
        DoWork2();
        DoWork3();
    }

    // It uses the processor context static variables

    // Im using the stack based context
    // Instead of using the normal context =>  ProcessorContext.PersonName
    public void DoWork1()
    {
        //..
        Console.WriteLine($"{ProcessorContextStack.Current.PersonName} Done Work1");
    }

    public void DoWork2()
    {
        //..
        Console.WriteLine($"{ProcessorContextStack.Current.PersonName} Done Work1");
    }

    public void DoWork3()
    {
        //..
        Console.WriteLine($"{ProcessorContextStack.Current.PersonName} Done Work1");
    }
}

// This one here too 
// It's even shared among any other class to use
public class Logger
{
    // No need to pass the userName
    public void Log(string message)
    {
        // It can access the global shared variable between it and the processor
        // I Can now print the name of the user before the message
        // Before: You had to pass it to the logger
        Console.WriteLine($"[{ProcessorContextStack.Current.PersonName}] {message}");
    }
}
