namespace DesignPattern.Entity.BehavioralPatterns.CommandPattern
{
    public class Number
    {
        public Number(int value)
        {
            Value = value;
        }

        public Number(double value)
        {
            Value = value;
        }

        public double Value { get; private set; }

        public Number Sum(Number value)
        {
            Value += value.Value;
            return this;
        }

        public Number Sub(Number value)
        {
            Value -= value.Value;
            return this;
        }

        public Number Mul(Number value)
        {
            Value *= value.Value;
            return this;
        }

        public Number Div(Number value)
        {
            Value /= value.Value;
            return this;
        }

        public override string ToString()
        {
            return $"Number: {Value}";
        }

        public static implicit operator Number(int value)
        {
            return new Number(value);
        }

        public static implicit operator Number(double value)
        {
            return new Number(value);
        }
    }

    public interface IOperator
    {
        Number Operate();
    }
}