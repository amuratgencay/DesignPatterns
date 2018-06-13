using System.Collections.Generic;
using System.Linq;
using DesignPattern.Entity.BehavioralPatterns.ChainofResponsibilityPattern;

namespace DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern
{
    public class Banknote : Money
    {
        private readonly List<Money> Moneys = new List<Money>();

        public Banknote(int amount, int count)
        {
            Amount = amount;
            for (var i = 0; i < count; i++)
            {
                Moneys.Add(new Money {Amount = amount});
            }
        }

        public Banknote Next { get; set; }
        public int Count => Moneys.Count;

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