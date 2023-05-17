namespace SOLID_OC_Principle.Infrastructure.Specifications
{
    using SOLID_OC_Principle.Infrastructure.Interfaces;
    using SOLID_OC_Principle.Models;
    using System.Collections.Generic;

    public class AndSpecification : ISpecification<Product>
    {
        private readonly CategorySpecification _categorySpecification;
        private readonly BrandSpecification _brandSpecification;

        public AndSpecification(CategorySpecification categorySpec, BrandSpecification brandSpec)
        {
            _categorySpecification = categorySpec;
            _brandSpecification = brandSpec;
        }

        public bool IsSatisfied(Product product)
            => _categorySpecification.IsSatisfied(product) &&
               _brandSpecification.IsSatisfied(product);
    }
}
