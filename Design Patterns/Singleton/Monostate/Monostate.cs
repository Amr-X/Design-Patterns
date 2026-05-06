namespace Singleton.Monostate;

// It's weird but works as a singleton
// You can create different objects but each manipulates shared data
public class Monostate
{
    private static string data1;
    private static string data2;
    private static string data3;

    public Monostate()
    {
    }

    public string Data1
    {
        get => data1;
        set => data1 = value;
    }

    public string Data2
    {
        get => data2;
        set => data2 = value;
    }

    public string Data3
    {
        get => data3;
        set => data3 = value;
    }
}