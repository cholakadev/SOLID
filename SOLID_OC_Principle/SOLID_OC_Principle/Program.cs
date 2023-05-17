using SOLID_OC_Principle.Enums;
using SOLID_OC_Principle.Infrastructure.Filters;
using SOLID_OC_Principle.Infrastructure.Specifications;
using SOLID_OC_Principle.Models;

var products = new List<Product>
{
    new Product("Audi", Category.Combi, Color.Purple),
    new Product("BMW", Category.Sedan, Color.Yellow),
    new Product("Volvo", Category.Combi, Color.Purple),
    new Product("Ford", Category.Cabriolet, Color.Blue),
    new Product("Jaguar", Category.Sedan, Color.Green),
    new Product("Audi", Category.Combi, Color.Green),
};

// filter products by Category

var filter = new ProductsFilter();
var filteredProducts = filter.Filter(products, new CategorySpecification(Category.Combi));

foreach(var product in filteredProducts)
{
    Console.WriteLine(product.ToString());
}

// filter products by Category and Name
var multipleFilteredProducts = filter.Filter(products,
                                            new AndSpecification(
                                                new CategorySpecification(Category.Combi),
                                                new BrandSpecification("Audi")));

foreach (var product in multipleFilteredProducts)
{
    Console.WriteLine(product.ToString());
}