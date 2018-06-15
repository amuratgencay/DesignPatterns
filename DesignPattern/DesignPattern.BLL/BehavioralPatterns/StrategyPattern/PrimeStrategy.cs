using System;
using System.Diagnostics;
using DesignPattern.Entity.BehavioralPatterns.StrategyPattern;

namespace DesignPattern.BLL.BehavioralPatterns.StrategyPattern
{
    public class PrimeStrategy
    {
        private readonly IStrategy strategy;

        public PrimeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public TimeSpan Execute(int min, int max, ref int count)
        {
            var cnt = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var i = min; i < max; i++)
                if (strategy.IsPrime(i))
                    cnt++;

            count = cnt;
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}