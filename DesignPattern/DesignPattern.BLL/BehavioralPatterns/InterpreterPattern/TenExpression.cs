using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class TenExpression : Expression
    {
        protected override string One()
        {
            return "X";
        }

        protected override string Four()
        {
            return "XL";
        }

        protected override string Five()
        {
            return "L";
        }

        protected override string Nine()
        {
            return "XC";
        }

        protected override int Multiplier()
        {
            return 10;
        }
    }
}