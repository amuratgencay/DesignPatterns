using System;
using DesignPattern.Entity.BehavioralPatterns.StatePattern;

namespace DesignPattern.BLL.BehavioralPatterns.StatePattern
{
    public class Context
    {
        private readonly Node _node;

        public Context(string value)
        {
            Value = value;

            _node = new Node("Even");
            _node.Next = new Node("Odd");
            _node.Next.Next = _node;
        }

        public Context(int value) : this(Convert.ToString(value, 2))
        {
        }

        public string Value { get; }

        public string Count()
        {
            var res = _node;
            foreach (var item in Value.ToCharArray())
                if (item == '1')
                    res = res.Next;
            return res.ToString();
        }
    }
}