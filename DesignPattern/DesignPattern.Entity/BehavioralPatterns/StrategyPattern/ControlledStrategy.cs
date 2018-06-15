using System;

namespace DesignPattern.Entity.BehavioralPatterns.StrategyPattern
{
    public class ControlledStrategy : IStrategy
    {
        public bool IsPrime(int value)
        {
            if (value < 2) return false;
            if (value <= 3) return true;
            if ((value * value - 25) % 24 != 0) return false;
            for (var i = 2; i <= Math.Sqrt(value); i++)
                if (value % i == 0)
                    return false;
            return true;
        }
    }
}