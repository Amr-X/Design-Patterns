using System;

namespace Builder.Car;

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public bool HasSunroof { get; set; }
    public bool HasLeatherSeats { get; set; }
    public bool HasGPS { get; set; }
    public int EngineCC { get; set; }
    public bool IsTurbo { get; set; }

    // Yeah, It's bad
    public Car(
        string model = "Default Model",
        string color = "Default Color",
        int year = 2020,
        bool hasSunroof = false,
        bool hasLeatherSeats = false,
        bool hasGPS = false,
        int engineCC = 2000,
        bool isTurbo = false
    )
    {
        Model = model;
        Color = color;
        Year = year;
        HasSunroof = hasSunroof;
        HasLeatherSeats = hasLeatherSeats;
        HasGPS = hasGPS;
        EngineCC = engineCC;
        IsTurbo = isTurbo;
    }
}
