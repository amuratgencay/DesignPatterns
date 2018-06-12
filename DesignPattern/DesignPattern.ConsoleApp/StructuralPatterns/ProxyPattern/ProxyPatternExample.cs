
using DesignPattern.BLL.StructuralPatterns.ProxyPattern;
using DesignPattern.Entity.StructuralPatterns.ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ConsoleApp.StructuralPatterns.FlyweightPattern
{
    public static class ProxyPatternExample
    {
        public static void Run()
        {
            IWriter pw = new ProxyWriter(WriterType.Console);
            Console.WriteLine("<Proxy Pattern Example>");
            Console.WriteLine();
            pw.Write("\tMessage");
            Console.WriteLine();
            Console.WriteLine("</Proxy Pattern Example>");
            Console.WriteLine();
        }
    }
}
