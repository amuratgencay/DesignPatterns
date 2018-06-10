using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.BuilderPattern
{    
    public class Food
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double DefaultWeight { get; set; }
        public Food(string name, double calorie, double defaultWeight)
        {
            Name = name;
            Calorie = calorie;
            DefaultWeight = defaultWeight;
        }
    }
}
