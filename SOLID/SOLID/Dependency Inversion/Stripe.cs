using System;

namespace SOLID.Dependency_Inversion;

// Stripe API
public class Stripe : IPaymentMethod
{
    public void MakePayment(Person person, int amount)
    {
        MakePaymentInCents(person, amount * 100);
    }

    // A Different method - API
    public void MakePaymentInCents(Person person, int amountInCents)
    {
        Console.WriteLine(
            $"Successfully made payment of {amountInCents / 100.0:C} for {person.Name} using Stripe."
        );
    }
}
