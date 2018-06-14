namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Sum : IOperator
    {
        private readonly Number _op1;
        private readonly Number _op2;

        public Sum(Number op1, Number op2)
        {
            _op1 = op1;
            _op2 = op2;
        }

        public Number Operate()
        {
            return _op1.Sum(_op2);
        }
    }
}