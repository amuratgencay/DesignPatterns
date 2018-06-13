using DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.ChainofResponsibilityPattern
{
    public static class ChainofResponsibilityPatternExample
    {
        public static void Run()
        {
            var atm = new ATM(new List<Banknote> { new Banknote(200, 3), new Banknote(100, 5), new Banknote(50, 25), new Banknote(20, 30), new Banknote(10, 100), new Banknote(5, 150), new Banknote(1, 200) });
            Console.WriteLine("<Chain of Responsibility Pattern Example>");
            Console.WriteLine();
            foreach (var item in atm.GetMoney(1375))
            {
                
                Console.WriteLine("\t" + item.Count + "x" + item.Amount  );
            }
            Console.WriteLine();
            Console.WriteLine("</Chain of Responsibility Pattern Example>");
            Console.WriteLine();
        }
    }
}
