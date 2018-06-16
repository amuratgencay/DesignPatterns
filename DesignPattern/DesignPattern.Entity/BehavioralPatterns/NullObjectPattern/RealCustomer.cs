namespace DesignPattern.Entity.BehavioralPatterns.NullObjectPattern
{
    public class RealCustomer : Customer
    {
        public RealCustomer(string name) : base(name)
        {
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}