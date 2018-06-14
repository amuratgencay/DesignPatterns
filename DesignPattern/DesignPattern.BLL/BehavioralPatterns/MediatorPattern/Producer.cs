using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DesignPattern.Entity.BehavioralPatterns.MediatorPattern;

namespace DesignPattern.BLL.BehavioralPatterns.MediatorPattern
{
    public class Mediator
    {
        private bool _slotFull;
        private int _number;
        private static object wlocker = new object();
        private static object rlocker = new object();

        public void StoreMessage(int value)
        {
            lock (wlocker)
            {
                while (_slotFull)
                {
                    Thread.SpinWait(10);
                }
                _slotFull = true;
                _number = value;
            }
            
        }

        public int RetrieveMessage()
        {
            lock (rlocker)
            {
                while (!_slotFull)
                {
                    Thread.SpinWait(10);
                }
                _slotFull = false;
                return _number;
            }
        }
    }
    public abstract class Runnable
    {
        protected Mediator Mediator;
        protected int Id;
        protected Runnable(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    public class Consumer : Runnable
    {
        private static int _index = 1;
        public Consumer(Mediator mediator) : base(mediator)
        {
            Id = _index++;
        }

        public void Run()
        {
            while (true)
            {
                var num = Mediator.RetrieveMessage();
                if (num == -1)
                    break;

                var isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if ((num%i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"C[{Id}] -> Prime:\t{num}");
            }
        }
    }
    public class Producer : Runnable
    {
        private NumRange _numRange;
        private static int _index = 1;

        public Producer(Mediator mediator, int min, int max) : base(mediator)
        {
            _numRange = new NumRange(min, max);
            Id = _index++;
        }

        public void Run()
        {
            while (_numRange.Active < _numRange.Max)
            {
                var num = _numRange.Active;
                Mediator.StoreMessage(num);
                Console.WriteLine($"P[{Id}] -> {num}");
                _numRange.Active++;
            }
            Mediator.StoreMessage(-1);
        }
    }

    public static class MediatorPatternExample
    {
        public static void Run()
        {
            var threads = new List<Thread>();
            Mediator mb = new Mediator();
            threads.Add(new Thread(new Producer(mb, 3, 1000).Run));
            threads.Add(new Thread(new Producer(mb, 1001, 2000).Run));
            threads.Add(new Thread(new Consumer(mb).Run));
            threads.Add(new Thread(new Consumer(mb).Run));
            foreach (var thread in threads)
            {
                thread.Start();
            }
        }
    }
}
