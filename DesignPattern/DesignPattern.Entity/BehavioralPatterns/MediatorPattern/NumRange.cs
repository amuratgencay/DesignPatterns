using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.BehavioralPatterns.MediatorPattern
{
    public class NumRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Active { get; set; }

        public NumRange(int min, int max)
        {
            Min = min;
            Active = min;
            Max = max;
        }        
    }
}
