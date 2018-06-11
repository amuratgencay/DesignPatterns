namespace DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Fill
{
    public class Blue : IFill
    {
        public string Fill()
        {
            return "blue";
        }

        public override string ToString()
        {
            return $"Shape filled with {Fill()}.";
        }
    }
}