using System;

namespace Builder.Car;

// Stepwise builder: Forces the client to build the object in a specific order
// Required: 1- Model, Color, Year - One after the other
//           2- If Model "Model S" You can only have Red or Black color

public interface IModelStep
{
    public IColorStep MakeModel(string model);
}

public interface IColorStep
{
    public IYearStep OfColor(string color);
}

public interface IYearStep
{
    public CarBuilderStepwise InYear(int year);
}

public class CarBuilderStepwise : IModelStep, IColorStep, IYearStep
{
    private Car Car { get; set; }

    public CarBuilderStepwise()
    {
        Car = new Car();
    }

    public IModelStep Create()
    {
        return this;
    }

    public IColorStep MakeModel(string model)
    {
        Car.Model = model;
        return this;
    }

    public IYearStep OfColor(string color)
    {
        if (Car.Model == "Model S")
        {
            if (!(color == "Red" || color == "Black"))
                throw new Exception("Model S Can Only Be Red Or Black");
        }
        Car.Color = color;
        return this;
    }

    public CarBuilderStepwise InYear(int year)
    {
        Car.Year = year;
        return this;
    }

    public Car Build()
    {
        return Car;
    }
}
