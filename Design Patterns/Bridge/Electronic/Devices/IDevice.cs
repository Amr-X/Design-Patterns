namespace Bridge.Electronic.Devices;

public interface IDevice
{
    bool IsEnabled { get; }
    void Enable();
    void Disable();


    int Volume { get; set; }
    int Channel { get; set; }
}