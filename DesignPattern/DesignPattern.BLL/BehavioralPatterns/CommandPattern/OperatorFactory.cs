using System;
using DesignPattern.Entity.BehavioralPatterns.CommandPattern;

namespace DesignPattern.BLL.BehavioralPatterns.CommandPattern
{
    public class OperatorFactory
    {
        public IOperator GetOperator(OperatorType operatorType)
        {
            switch (operatorType)
            {
                case OperatorType.Add:
                    return new Sum();
                case OperatorType.Sub:
                    return new Sub();
                case OperatorType.Mul:
                    return new Mul();
                case OperatorType.Div:
                    return new Div();
                default:
                    throw new ArgumentOutOfRangeException(nameof(operatorType), operatorType, null);
            }
        }
    }
}