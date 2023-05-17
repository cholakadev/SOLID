namespace SOLID_OC_Principle.Models
{
    using SOLID_OC_Principle.Enums;

    public class Product
    {
        public Product(string brand, Category category, Color color)
        {
            Brand = brand ?? throw new ArgumentNullException(nameof(brand));
            Category = category;
            Color = color;
        }

        public string Brand { get; set; }

        public Category Category { get; set; }

        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{Brand} ({Color}) - {Category}";
        }
    }
}
