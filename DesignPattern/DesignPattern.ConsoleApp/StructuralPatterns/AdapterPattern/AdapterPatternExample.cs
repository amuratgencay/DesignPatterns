using System;
using DesignPattern.BLL.StructuralPatterns.AdapterPattern;
using DesignPattern.Entity.StructuralPatterns.AdapterPattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.AdapterPattern
{
    public static class AdapterPatternExample
    {
        public static void Run()
        {
            Compound water = new RichCompound(CompoundType.Water);
            Compound benzene = new RichCompound(CompoundType.Benzene);
            Compound ethanol = new RichCompound(CompoundType.Ethanol);

            Console.WriteLine("<Adapter Pattern Example>");
            Console.WriteLine();
                Console.WriteLine(water);
                Console.WriteLine(benzene);
                Console.WriteLine(ethanol);
            Console.WriteLine();
            Console.WriteLine("</Adapter Pattern Example>");
            Console.WriteLine();



            
            
        }
    }
}
