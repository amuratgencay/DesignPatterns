using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.BehavioralPatterns.NullObjectPattern
{
    public abstract class Customer
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        private static int lastId = 0;
        public abstract bool IsNull();

        protected Customer(string name)
        {
            Id = ++lastId;
            Name = name;
        }

        public override string ToString()
        {
            return $"Customer[{Id}] -> Name: {Name}";
        }
    }
}
