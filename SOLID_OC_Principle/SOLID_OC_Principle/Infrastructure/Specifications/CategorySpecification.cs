namespace SOLID_OC_Principle.Infrastructure.Specifications
{
    using SOLID_OC_Principle.Enums;
    using SOLID_OC_Principle.Infrastructure.Interfaces;
    using SOLID_OC_Principle.Models;

    public class CategorySpecification : ISpecification<Product>
    {
        private Category _category;

        public CategorySpecification(Category category)
        {
            _category = category;
        }

        public bool IsSatisfied(Product product)
            => product.Category == _category;
    }
}
