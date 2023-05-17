namespace SOLID_OC_Principle.Infrastructure.Filters
{
    using SOLID_OC_Principle.Infrastructure.Interfaces;
    using SOLID_OC_Principle.Models;

    public class ProductsFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var product in products)
            {
                if (spec.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}
