namespace DesignPattern.Entity.BehavioralPatterns.ObserverPattern
{
    public abstract class Element : ConsoleWriter
    {
        protected Element(View view, int left, int top, int cLeft, int cTop) : base(left, top, cLeft, cTop)
        {
            View = view;
            View.Attach(this);
        }

        protected View View { get; set; }
        public abstract void Render();
    }
}