namespace Bridge.Electronic.Devices;

public class Radio : IDevice
{
    public bool IsEnabled { get; private set; }

    public int Volume { get; set; }
    public int Channel { get; set; }

    public void Disable()
    {
        Console.WriteLine("Radio is turned off");
        IsEnabled = false;
    }

    public void Enable()
    {
        Console.WriteLine("Radio is turned on");
        IsEnabled = true;
    }
}