using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class HundredExpression : Expression
    {
        protected override string One() => "C";
        protected override string Four() => "CD";
        protected override string Five() => "D";
        protected override string Nine() => "CM";
        protected override int Multiplier() => 100;
    }
}