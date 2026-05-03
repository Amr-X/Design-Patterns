using System;
using System.Diagnostics.Contracts;

namespace SOLID.Liskov_Substitution;

// Bad! Not All Birds Can Fly
// public class Bird
// {
//     public virtual void Fly() => Console.WriteLine("Some Bird is Flying..");
// }
// Good
public interface IBird
{
    // Other Bird Stuff
}

public class Bird : IBird
{
    // Other Bird Stuff
}

public class FlyingBird : IBird
{
    public virtual void Fly() => Console.WriteLine("Some Bird is Flying..");
}

public class Sparrow : FlyingBird
{
    public override void Fly() => Console.WriteLine("Sparrow Bird is Flying..");
}

// Bad! We are not honoring the primes of the base
// Ostrich is Bird <- That is not the problem
// : Bird  Which is a bird that can't fly
public class Ostrich : Bird
{
    // public override void Fly() => throw new NotImplementedException("Ostrich can't fly.");
}
