using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.BLL.BehavioralPatterns.TemplatePattern
{
    public class TemplateList
    {
        private readonly List<int> _list = new List<int>();

        public TemplateList(int count)
        {
            var rnd = new Random((int) DateTime.Now.Ticks);
            for (var i = 0; i < count; i++) _list.Add(rnd.Next(10));
        }

        public TemplateList SortAsc()
        {
            var st = new SortAsc<int>();
            st.Sort(_list);
            return this;
        }

        public TemplateList SortDesc()
        {
            var st = new SortDesc<int>();
            st.Sort(_list);
            return this;
        }

        public override string ToString()
        {
            var res = _list.Aggregate("{", (x, y) => x + (x != "{" ? ", " : "") + y) + "}";
            return res;
        }
    }
}