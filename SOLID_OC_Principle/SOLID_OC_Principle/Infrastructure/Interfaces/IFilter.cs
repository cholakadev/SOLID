namespace SOLID_OC_Principle.Infrastructure.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> products, ISpecification<T> spec);
    }
}
