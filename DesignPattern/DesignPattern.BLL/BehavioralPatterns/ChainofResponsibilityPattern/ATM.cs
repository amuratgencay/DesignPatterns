using DesignPattern.Entity.BehavioralPatterns.ChainofResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern
{
    public class ATM
    {
        private readonly Banknote banknote;
        public ATM(List<Banknote> banknotes)
        {
            foreach (var item in banknotes)
            {
                if(banknote == null)
                {
                    banknote = item;
                }
                else
                {
                    banknote.AddNext(item);
                }
            }
        }

        private List<Banknote> GetMoney(int amount, Banknote root, ref List<Banknote> banknotes)
        {
            if ((root == null) || (amount == 0))
                return banknotes;

            if((root.Amount > amount) || (root.Count == 0))
            {
                return GetMoney(amount, root.Next, ref banknotes);
            }
            var money = root.GetMoney();
            if(banknotes.Any(x=>x.Amount == money.Amount))
            {
                banknotes.FirstOrDefault(x => x.Amount == money.Amount)?.AddMoney(money);
            }
            else
            {
                banknotes.Add(new Banknote(money.Amount, 1));
            }
            
            amount -= money.Amount;
            return GetMoney(amount, root, ref banknotes);
        }
        public List<Banknote> GetMoney(int amount)
        {
            var banknotes = new List<Banknote>();
            var res =  GetMoney(amount, banknote, ref banknotes);
            return res;
        }

    }
}
