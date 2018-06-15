using System;
using DesignPattern.Entity.BehavioralPatterns.TemplatePattern;

namespace DesignPattern.BLL.BehavioralPatterns.TemplatePattern
{
    public class SortDesc<T> : SortTemplate<T> where T : IComparable
    {
        public override bool NeedSwap(T p1, T p2)
        {
            return p1.CompareTo(p2) > 0;
        }
    }
}