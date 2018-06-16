namespace DesignPattern.Entity.BehavioralPatterns.VisitorPattern
{
    public abstract class Printer
    {
        protected Printer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Model { get; set; }
        public string Brand { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }
    }
}