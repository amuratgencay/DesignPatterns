using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public abstract class Shape
    {
        protected readonly IDrawable Drawable;

        protected Shape(IDrawable drawable)
        {
            Drawable = drawable;
        }
        public abstract void Draw();
    }
}
