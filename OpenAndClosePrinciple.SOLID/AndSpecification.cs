using System;

namespace OpenAndClosePrinciple.SOLID
{
    //The general idea of this principle is great. It tells you to write your code 
    //so that you will be able to add new functionality without changing the existing code. 
    //That prevents situations in which a change to one of your classes also requires you 
    //to adapt all depending classes. Unfortunately, Bertrand Mayer proposes to use inheritance to achieve this goal:

    // combinator
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product p)
        {
            return first.IsSatisfied(p) && second.IsSatisfied(p);
        }
    }
}