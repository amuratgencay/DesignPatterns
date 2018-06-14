namespace DesignPattern.Entity.BehavioralPatterns.InterpreterPattern
{
    class ThousandExpression : Expression
    {
        protected override string One()  => "M"; 
        protected override string Four() => " "; 
        protected override string Five() => " "; 
        protected override string Nine() => " "; 
        protected override int Multiplier() => 1000; 
    }
}