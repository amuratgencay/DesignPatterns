namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Div : IOperator
    {
        private readonly Number _op1;
        private readonly Number _op2;

        public Div(Number op1, Number op2)
        {
            _op1 = op1;
            _op2 = op2;
        }

        public Number Operate()
        {
            return _op1.Div(_op2);
        }
    }
}