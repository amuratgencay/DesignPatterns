using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class TenExpression : Expression
    {
        protected override string One() => "X";
        protected override string Four() => "XL";
        protected override string Five() => "L";
        protected override string Nine() => "XC";
        protected override int Multiplier() => 10;
    }
}