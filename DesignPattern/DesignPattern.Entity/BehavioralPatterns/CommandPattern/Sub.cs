namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Sub : IOperator
    {
        private readonly Number _op1;
        private readonly Number _op2;

        public Sub(Number op1, Number op2)
        {
            _op1 = op1;
            _op2 = op2;
        }

        public Number Operate()
        {
            return _op1.Sub(_op2);
        }
    }
}