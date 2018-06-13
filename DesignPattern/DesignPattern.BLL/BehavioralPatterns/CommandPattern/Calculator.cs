using System;
using System.Linq;
using DesignPattern.Entity.BehavioralPatterns.CommandPattern;

namespace DesignPattern.BLL.BehavioralPatterns.CommandPattern
{
    public class Calculator
    {
        public double Calculate(string expression)
        {
            var operatorFactory = new OperatorFactory();
            var operators = "+-*/";

            for (var i = 0; i < expression.Length; i++)
            {
                var c = expression[i];
                if (operators.Contains(c))
                {
                    var operatorType = (OperatorType) c;
                    var op1 = Convert.ToDouble(expression.Substring(0, i).Trim());
                    var op2 = Convert.ToDouble(expression.Remove(0, i + 1).Trim());
                    return operatorFactory.GetOperator(operatorType).Operate(op1, op2);
                }
            }
            return 0;
        }
    }
}