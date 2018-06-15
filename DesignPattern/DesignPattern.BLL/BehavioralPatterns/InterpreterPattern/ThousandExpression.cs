using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class ThousandExpression : Expression
    {
        protected override string One()
        {
            return "M";
        }

        protected override string Four()
        {
            return " ";
        }

        protected override string Five()
        {
            return " ";
        }

        protected override string Nine()
        {
            return " ";
        }

        protected override int Multiplier()
        {
            return 1000;
        }
    }
}