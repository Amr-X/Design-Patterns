using System;

namespace SOLID.Dependency_Inversion;

public interface IPaymentMethod
{
    void MakePayment(Person person, int amount);
}
