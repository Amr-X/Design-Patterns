using Bridge.Electronic.Devices;

namespace Bridge.Electronic.Remotes;

public class AdvancedRemote : Remote
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        Device.Volume = 0;
    }
}