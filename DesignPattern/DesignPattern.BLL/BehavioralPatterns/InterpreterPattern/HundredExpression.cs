using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class HundredExpression : Expression
    {
        protected override string One()
        {
            return "C";
        }

        protected override string Four()
        {
            return "CD";
        }

        protected override string Five()
        {
            return "D";
        }

        protected override string Nine()
        {
            return "CM";
        }

        protected override int Multiplier()
        {
            return 100;
        }
    }
}