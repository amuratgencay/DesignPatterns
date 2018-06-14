using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class OneExpression : Expression
    {
        protected override string One() => "I";
        protected override string Four() => "IV";
        protected override string Five() => "V";
        protected override string Nine() => "IX";
        protected override int Multiplier() => 1;
    }
}