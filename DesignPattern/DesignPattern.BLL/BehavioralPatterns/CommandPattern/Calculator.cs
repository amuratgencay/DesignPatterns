using System;
using System.Collections.Generic;
using DesignPattern.Entity.BehavioralPatterns.CommandPattern;

namespace DesignPattern.BLL.BehavioralPatterns.CommandPattern
{
    public class Calculator
    {
        private readonly List<IOperator> _operators = new List<IOperator>();

        public void AddOperation(IOperator operation)
        {
            _operators.Add(operation);
        }

        public Number Calculate()
        {
            Number res = null;
            foreach (var item in _operators)
            {
                res = item.Operate();
                Console.WriteLine("\t" + item.GetType().Name + " -> " + res);
            }

            return res;
        }
    }
}