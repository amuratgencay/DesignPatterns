namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Mul : IOperator
    {
        public double Operate(double op1, double op2) => op1*op2;
    }
}