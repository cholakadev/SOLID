namespace SOLID_OC_Principle.Infrastructure.Specifications
{
    using SOLID_OC_Principle.Infrastructure.Interfaces;
    using SOLID_OC_Principle.Models;

    public class BrandSpecification : ISpecification<Product>
    {
        private string _brand;

        public BrandSpecification(string brand)
        {
            _brand = brand;
        }

        public bool IsSatisfied(Product product)
            => product.Brand == _brand;
    }
}
