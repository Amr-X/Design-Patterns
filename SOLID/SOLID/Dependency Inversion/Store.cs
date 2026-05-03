using System;
using SOLID.Open_Closed;

namespace SOLID.Dependency_Inversion;

public class Store
{
    // BAD! Store Depends on Low-Level Module (Paypal)
    // A Change to Paypal Api will affect Store class
    // What if we want to use other payment method (Stripe) with making a big change to Store class?
    // You need a Common Separation (Abstraction Through an Interface - PaymentMethod) between Store and Any Payment Method
    // You can Swap Payment Methods without changing Store Class (OSP)

    // private Paypal Paypal { get; set; }

    // Good! We Deal (Depend) on Abstraction
    private IPaymentMethod PaymentMethod { get; set; }

    public Store(IPaymentMethod paymentMethod)
    {
        PaymentMethod = paymentMethod;
    }

    public void Buy(Product product, Person person)
    {
        PaymentMethod.MakePayment(person, product.Amount);
    }
}
