using System;

namespace DesignPattern.Entity.AbstractFactoryPattern.Fill
{
    public class Green : IFill
    {

        public string Fill()
        {
            return "green";
        }

        public override string ToString()
        {
            return $"Shape filled with { Fill() }.";
        }

    }
}
