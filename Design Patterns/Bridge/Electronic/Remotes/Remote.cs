using Bridge.Electronic.Devices;

namespace Bridge.Electronic.Remotes;

public class Remote : IRemote
{
    protected readonly IDevice Device;

    // What ever the device this is
    public Remote(IDevice device)
    {
        Device = device;
    }

    public void ChannelDown()
    {
        Device.Channel--;
    }

    public void ChannelUp()
    {
        Device.Channel++;
    }

    public void TogglePower()
    {
        if (Device.IsEnabled)
            Device.Disable();
        else
            Device.Enable();
    }

    public void VolumeDown()
    {
        Device.Volume--;
    }

    public void VolumeUp()
    {
        Device.Volume++;
    }
}