using System;
using System.Collections.Generic;

namespace DesignPattern.Entity.BehavioralPatterns.TemplatePattern
{
    public abstract class SortTemplate<T> where T : IComparable
    {
        public abstract bool NeedSwap(T p1, T p2);

        public void Sort(List<T> list)
        {
            for (var i = 0; i < list.Count - 1; i++)
            for (var j = 0; j < list.Count - i - 1; j++)
                if (NeedSwap(list[j], list[j + 1]))
                {
                    var tmp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = tmp;
                }
        }
    }
}