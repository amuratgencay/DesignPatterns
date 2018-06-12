using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.Entity.StructuralPatterns.CompositePattern;

namespace DesignPattern.BLL.StructuralPatterns.CompositePattern
{
    public class CategoryManager
    {
        public CategoryManager()
        {
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        public void AddTopCategory(Category topCategory, Category category)
        {
            category.TopCategory = Categories.FirstOrDefault(x => x.Name == topCategory.Name);
            category.TopCategory.SubCategories.Add(category);
        }

        public void AddProduct(Category category, Product product)
        {
            category.Products.Add(product);
        }

        private void RecursiveListCategories(Category category, string tab)
        {
            if (category == null)
                return;

            category.Products.ForEach(item => Console.WriteLine(tab + item));
            category.SubCategories.ForEach(item =>
            {
                Console.WriteLine(tab + $"<{item}>");
                RecursiveListCategories(item, tab + "\t");
                Console.WriteLine(tab + $"</{item}>");
            });
        }

        public void ListCategories()
        {
            var tab = "\t";
            Categories.ForEach(item =>
            {
                Console.WriteLine(tab + $"<{item}>");
                RecursiveListCategories(item, tab + "\t");
                Console.WriteLine(tab + $"</{item}>");
            });
        }
    }
}