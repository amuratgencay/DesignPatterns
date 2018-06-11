using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public abstract class Shape
    {
        protected IDrawable _drawable;
        public Shape(IDrawable drawable)
        {
            _drawable = drawable;
        }
        public abstract void Draw();
    }
}
