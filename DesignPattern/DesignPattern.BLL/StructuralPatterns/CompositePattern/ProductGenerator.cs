using DesignPattern.Entity.StructuralPatterns.CompositePattern;

namespace DesignPattern.BLL.StructuralPatterns.CompositePattern
{
    public static class ProductGenerator
    {
        public static CategoryManager GenerateProducts()
        {
            var computer = new Category("Computer");
            var laptop = new Category("Laptop");
            var pc = new Category("PC");

            var lenovo = new Product("Lenovo", 2599m);
            var hp = new Product("HP", 2399m);

            var casper = new Product("Casper", 1699m);
            var apple = new Product("Apple", 5499m);

            var cm = new CategoryManager();
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