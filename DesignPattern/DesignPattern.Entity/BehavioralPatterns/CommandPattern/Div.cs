namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Div : IOperator
    {
        public double Operate(double op1, double op2) => op1/op2;
    }
}