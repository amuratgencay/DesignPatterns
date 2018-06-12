using DesignPattern.Entity.StructuralPatterns.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.StructuralPatterns.CompositePattern
{
    public static class ProductGenerator
    {
        public static CategoryManager GenerateProducts()
        {
            Category computer = new Category("Computer");
            Category laptop = new Category("Laptop");
            Category pc = new Category("PC");

            Product lenovo = new Product("Lenovo", 2599m);
            Product hp = new Product("HP", 2399m);

            Product casper = new Product("Casper", 1699m);
            Product apple = new Product("Apple", 5499m);

            CategoryManager cm = new CategoryManager();
            cm.AddCategory(computer);
            cm.AddTopCategory(computer, laptop);
            cm.AddTopCategory(computer, pc);

            cm.AddProduct(laptop, lenovo);
            cm.AddProduct(laptop, hp);

            cm.AddProduct(pc, casper);
            cm.AddProduct(pc, apple);

            return cm;
        } 
    }
}
