using System.Collections.Generic;

namespace OpenAndClosePrinciple.SOLID
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}