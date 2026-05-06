namespace Singleton.Ambient_Context;

// PersonName is passed everywhere
public class ProcessorNoContext
{
    // Now you can say that this is dump. Why can't we have PersonName Simply as a Field you may ask.
//    public string PersonName { get; set; }
    // This example is simple enough to just show the problem
    // But what if PersonName is something that two or more classes need to see as global shared variables -> Look at other example 

    public void DoWork(string personName)
    {
        DoWork1(personName);
        DoWork2(personName);
        DoWork3(personName);
    }

    public void DoWork1(string personName)
    {
        //..
        Log($"[{personName}] Done Work1");
    }

    public void DoWork2(string personName)
    {
        //..
        Log($"[{personName}] Done Work2");
    }

    public void DoWork3(string personName)
    {
        //..
        Log($"[{personName}] Done Work3");
    }

    private void Log(string message)
    {
        Console.WriteLine(message);
    }
}