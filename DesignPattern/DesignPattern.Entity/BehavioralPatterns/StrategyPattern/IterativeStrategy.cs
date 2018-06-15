using System;

namespace DesignPattern.Entity.BehavioralPatterns.StrategyPattern
{
    public class IterativeStrategy : IStrategy
    {
        public bool IsPrime(int value)
        {
            if (value < 2) return false;
            if (value == 2) return true;

            for (var i = 2; i <= Math.Sqrt(value); i++)
                if (value % i == 0)
                    return false;
            return true;
        }
    }
}