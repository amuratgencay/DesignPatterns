using System;
using DesignPattern.BLL.CreationalPatterns.BuilderPattern;

namespace DesignPattern.ConsoleApp.CreationalPatterns.BuilderPattern
{
    public static class BuilderPatternExample
    {
        private static Meal PreparePastry()
        {
            var res = new Meal("Pastry");
            res.AddPacking(new Cup(1, Ingredients.Cream));
            res.AddPacking(new Cup(0.5, Ingredients.SunFlowerOil));
            res.AddPacking(new Piece(1, Ingredients.Egg));
            res.AddPacking(new TableSpoon(1, Ingredients.Salt));
            res.AddPacking(new Cup(3, Ingredients.Flour));
            res.AddPacking(new Piece(1, Ingredients.BakingPowder));
            return res;
        }

        private static Meal PreparePancake()
        {
            var res = new Meal("Pancake");
            res.AddPacking(new Piece(2, Ingredients.Egg));
            res.AddPacking(new Cup(1.75, Ingredients.Flour));
            res.AddPacking(new Cup(1, Ingredients.Water));
            res.AddPacking(new Cup(1, Ingredients.Milk));
            res.AddPacking(new TableSpoon(1, Ingredients.Salt));
            res.AddPacking(new Cup(0.5, Ingredients.SunFlowerOil));
            return res;
        }

        public static void Run()
        {
            Console.WriteLine("<Builder Pattern Example>");
            Console.WriteLine();
                PreparePastry().ShowPacking();
                Console.WriteLine();
                Console.WriteLine();
                PreparePancake().ShowPacking();
            Console.WriteLine();
            Console.WriteLine("</Builder Pattern Example>");
            Console.WriteLine();
        }
    }
}
