using System;
using DesignPattern.BLL.BehavioralPatterns.TemplatePattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.TemplatePattern
{
    public static class TemplatePatternExample
    {
        public static void Run()
        {
            var list = new TemplateList(10);
            Console.WriteLine("<Template Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t List                  :" + list);
            Console.WriteLine("\t List Sorted Ascending :" + list.SortAsc());
            Console.WriteLine("\t List Sorted Descending:" + list.SortDesc());
            Console.WriteLine();
            Console.WriteLine("</Template Pattern Example>");
            Console.WriteLine();
        }
    }
}