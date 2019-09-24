using System.Collections.Generic;

namespace OpenAndClosePrinciple.SOLID
{
    /// <summary>
    /// This class is to Filter the products using the old method 
    /// to apply the Open and Close principle 
    /// we need to create the below interfaces 
    /// 1. ISpecification : And this is precisely the thing that will allow us to avoid violating the open closed principle.
    ///    becuase the FilterBySize and FilterBySizeAndColor violate the concept of Open and Closed principle.
    /// 2. IFilter 
    /// 
    /// A class is closed, since it may be compiled, stored in a library, baselined, and used by client classes. But it is also open, 
    /// since any new class may use it as parent, adding new features. When a descendant class is defined, there is no need to change 
    /// the original or to disturb its clients.”
    /// </summary>
    public class ProductFilter
    {
        // let's suppose we don't want ad-hoc queries on products
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        } // state space explosion
          // 3 criteria = 7 methods

        // OCP = open for extension but closed for modification
    }
}