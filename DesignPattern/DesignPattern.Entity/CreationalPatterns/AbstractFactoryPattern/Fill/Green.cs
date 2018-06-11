namespace DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Fill
{
    public class Green : IFill
    {
        public string Fill()
        {
            return "green";
        }

        public override string ToString()
        {
            return $"Shape filled with {Fill()}.";
        }
    }
}