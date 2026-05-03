using System;

namespace SOLID.Open_Closed;

// OCD -> Classes Should be Open for Extensions - Closed for Modifications
// If you want to extent the functionality of some class
// You shouldn't be open to just add more features -> BySize - ByColor - ..
// Because what if it's already being used? You change it Disaster Everywhere
// Analogy: Receptionist Job(Rule to pass) - You don't change the R's Job
// You Change the rule -> You Make a New Rule (You Extend it)
// Also: Sort(Comparer) -> You Want to change how you sort? Make a new Comparer

// You never touch this to change how you filter
// You extend it by Making Spec Classes
public class Filter
{
    public static IEnumerable<Product> FilterBy(
        IEnumerable<Product> products,
        ISpecification<Product> spec
    )
    {
        foreach (var p in products)
        {
            if (spec.IsSatisfied(p))
                yield return p;
        }
    }
}
