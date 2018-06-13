using DesignPattern.Entity.BehavioralPatterns.ChainofResponsibilityPattern;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern
{
    public class Banknote : Money
    {
        private readonly List<Money> Moneys = new List<Money>();
        public Banknote Next { get; set; }

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

        public Money TakeMoney()
        {
            var money = Moneys.FirstOrDefault();
            Moneys.Remove(money);
            return money;
        }

    }
}
