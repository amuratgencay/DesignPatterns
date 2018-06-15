using System;

namespace DesignPattern.Entity.BehavioralPatterns.ObserverPattern
{
    public class Hexa : Element
    {
        public Hexa(View view, int left, int top, int cLeft, int cTop) : base(view, left, top, cLeft, cTop)
        {
        }

        public override void Render()
        {
            Write(Convert.ToString(View.State, 16));
        }
    }
}