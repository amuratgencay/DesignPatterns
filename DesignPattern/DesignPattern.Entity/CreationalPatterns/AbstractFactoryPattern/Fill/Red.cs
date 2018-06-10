using System;

namespace DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Fill
{
    public class Red : IFill
    {

        public string Fill()
        {
            return "red";
        }

        public override string ToString()
        {
            return $"Shape filled with { Fill() }.";
        }
        
    }
}
