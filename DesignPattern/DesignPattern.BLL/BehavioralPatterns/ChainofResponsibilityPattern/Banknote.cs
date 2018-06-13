using DesignPattern.Entity.BehavioralPatterns.ChainofResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern
{
    public class Banknote
    {
        private readonly List<Money> Moneys = new List<Money>();
        public Banknote Next { get; set; }

        public int Amount { get; private set; }
        public int Count => Moneys.Count;

        public Banknote(int amount, int count)
        {
            Amount = amount;
            for (int i = 0; i < count; i++)
            {
                Moneys.Add(new Money { Amount = amount });
            }
        }

        public void AddNext(Banknote next)
        {
            if (Next == null)
            {
                Next = next;
            }
            else
            {
                Next.AddNext(next);
            }
        }
        public void AddMoney(Money money)
        {
            Moneys.Add(money);
        }
        public Money GetMoney()
        {
            var money = Moneys.FirstOrDefault();
            Moneys.Remove(money);
            return money;
        }

    }
}
