using System;

namespace DesignPattern.Entity.AbstractFactoryPattern.Fill
{
    public class Blue : IFill
    {

        public string Fill()
        {
            return "blue";
        }

        public override string ToString()
        {
            return $"Shape filled with { Fill() }.";
        }

    }
}
