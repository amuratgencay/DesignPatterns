using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.CompositePattern
{
    public class Category
    {
        public string Name { get; set; }
        public Category TopCategory { get; set; }
        public List<Category> SubCategories { get; set; }
        public List<Product> Products { get; set; }

        public Category(string name)
        {
            Name = name;            
            Products = new List<Product>();
            SubCategories = new List<Category>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
