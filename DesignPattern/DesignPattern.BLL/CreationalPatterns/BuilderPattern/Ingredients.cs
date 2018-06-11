using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public static class Ingredients
    {
        public static Food Cream => new Food("Cream", 42, 15);
        public static Food SunFlowerOil => new Food("Sunflower Oil", 142, 14);
        public static Food Egg => new Food("Egg", 55, 35);
        public static Food Salt => new Food("Salt", 0, 1);
        public static Food Flour => new Food("Flour", 431, 120);
        public static Food BakingPowder => new Food("Baking Powder", 3, 5);
        public static Food Water => new Food("Water", 0, 1);
        public static Food Milk => new Food("Milk", 158, 256);
    }
}