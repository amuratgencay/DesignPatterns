﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"Shape[{X},{Y}]";
        }
    }
}
