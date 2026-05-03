using System;
using SOLID.Open_Closed;

namespace SOLID.Dependency_Inversion;

// Paypal API
public class Paypal : IPaymentMethod
{
    public void MakePayment(Person person, int amount)
    {
        MakePaymentPaypal(person, amount);
    }

    public void MakePaymentPaypal(Person person, int amount)
    {
        Console.WriteLine($"Successfully made payment of {amount} for {person.Name} using Paypal.");
    }
}
