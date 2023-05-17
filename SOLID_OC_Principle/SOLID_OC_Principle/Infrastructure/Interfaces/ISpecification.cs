namespace SOLID_OC_Principle.Infrastructure.Interfaces
{
    using SOLID_OC_Principle.Models;

    public interface ISpecification<T>
    {
        bool IsSatisfied(Product product);
    }
}
