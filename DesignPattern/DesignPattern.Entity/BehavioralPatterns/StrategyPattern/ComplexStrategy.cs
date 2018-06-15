namespace DesignPattern.Entity.BehavioralPatterns.StrategyPattern
{
    public class ComplexStrategy : IStrategy
    {
        public bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            if (value <= 3)
                return true;
            if (value % 2 == 0 || value % 3 == 0)
                return false;
            if ((value * value - 25) % 24 != 0) return false;
            var i = 5;
            while (i * i <= value)
            {
                if (value % i == 0 || value % (i + 2) == 0)
                    return false;
                i = i + 6;
            }

            return true;
        }
    }
}