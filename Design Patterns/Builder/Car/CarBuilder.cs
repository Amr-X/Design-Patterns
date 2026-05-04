using System;

namespace Builder.Car;

public class CarBuilder
{
    // The car it builds
    public Car Car { get; private set; }

    public CarBuilder()
    {
        Car = new Car();
    }

    public CarBuilder MakeModel(string model)
    {
        Car.Model = model;
        return this;
    }

    public CarBuilder OfColor(string color)
    {
        Car.Color = color;
        return this;
    }

    public CarBuilder InYear(int year)
    {
        Car.Year = year;
        return this;
    }

    public CarBuilder HasSunroof(bool hasSunroof)
    {
        Car.HasSunroof = hasSunroof;
        return this;
    }

    public CarBuilder HasLeatherSeats(bool hasLeatherSeats)
    {
        Car.HasLeatherSeats = hasLeatherSeats;
        return this;
    }

    public CarBuilder HasGPS(bool hasGPS)
    {
        Car.HasGPS = hasGPS;
        return this;
    }

    public CarBuilder WithEngineCC(int engineCC)
    {
        Car.EngineCC = engineCC;
        return this;
    }
}
