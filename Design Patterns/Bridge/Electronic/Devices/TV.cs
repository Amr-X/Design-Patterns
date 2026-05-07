namespace Bridge.Electronic.Devices;

public class TV : IDevice
{
    public int Volume { get; set; }
    public int Channel { get; set; }

    public bool IsEnabled { get; private set; }

    public TV()
    {
        IsEnabled = false;
        Volume = 30;
        Channel = 1;
    }

    public void Disable()
    {
        Console.WriteLine("Tv is turned off");
        IsEnabled = false;
    }

    public void Enable()
    {
        Console.WriteLine("Tv is turned on");
        IsEnabled = true;
    }
}


    