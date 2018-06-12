using System.Collections.Generic;

namespace DesignPattern.Entity.StructuralPatterns.CompositePattern
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
            Products = new List<Product>();
            SubCategories = new List<Category>();
        }

        public string Name { get; set; }
        public Category TopCategory { get; set; }
        public List<Category> SubCategories { get; set; }
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}