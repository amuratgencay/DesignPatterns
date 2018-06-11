namespace DesignPattern.Entity.CreationalPatterns.BuilderPattern
{
    public class Food
    {
        public Food(string name, double calorie, double defaultWeight)
        {
            Name = name;
            Calorie = calorie;
            DefaultWeight = defaultWeight;
        }

        public string Name { get; set; }
        public double Calorie { get; set; }
        public double DefaultWeight { get; set; }
    }
}