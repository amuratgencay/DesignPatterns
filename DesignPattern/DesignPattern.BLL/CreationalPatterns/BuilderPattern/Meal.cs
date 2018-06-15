using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public class Meal
    {
        private readonly List<IPacking> _items = new List<IPacking>();

        public Meal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public double TotalCalories => _items.Sum(packing => packing.TotalCalories());

        public void AddPacking(IPacking item)
        {
            _items.Add(item);
        }

        public void ShowPacking()
        {
            Console.WriteLine("\t" + Name);
            foreach (var packing in _items) Console.WriteLine("\t\t" + packing);
            Console.WriteLine("\tTotal Calories = " + TotalCalories.ToString("F"));
        }
    }
}