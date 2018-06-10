using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.Entity.PrototypePattern;

namespace DesignPattern.BLL.PrototypePattern
{
    public static class FibonacciCache
    {
        private static readonly Dictionary<int, FibonacciNumber> _fibonacciCache = new Dictionary<int, FibonacciNumber>();

        public static FibonacciNumber GetFibonacciNumber(int num)
        {
            if (!_fibonacciCache.ContainsKey(num))
            {
                var i = _fibonacciCache.Keys.Max(x => x);
                for (; i <= num; i++)
                {
                    var fib = _fibonacciCache[i];
                    _fibonacciCache.Add(i + 1, new FibonacciNumber(i + 1, fib.Value, fib.First));
                }
            }
            FibonacciNumber value = (FibonacciNumber) _fibonacciCache[num].Clone();
            return value;
        }

        public static void LoadCache()
        {
            var fib = new FibonacciNumber(0, 1, 0); _fibonacciCache.Add(0, fib);
            fib = new FibonacciNumber(1, fib.Value, 0); _fibonacciCache.Add(1, fib);
            fib = new FibonacciNumber(2, fib.Value, fib.First); _fibonacciCache.Add(2, fib);
            fib = new FibonacciNumber(3, fib.Value, fib.First); _fibonacciCache.Add(3, fib);
            fib = new FibonacciNumber(4, fib.Value, fib.First); _fibonacciCache.Add(4, fib);
            fib = new FibonacciNumber(5, fib.Value, fib.First); _fibonacciCache.Add(5, fib);

        }
    }
}
