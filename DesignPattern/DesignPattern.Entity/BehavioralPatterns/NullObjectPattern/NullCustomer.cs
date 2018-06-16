namespace DesignPattern.Entity.BehavioralPatterns.NullObjectPattern
{
    public class NullCustomer : Customer
    {
        public NullCustomer() : base("Not Available")
        {

        }

        public override bool IsNull()
        {
            return true;
        }

        public override string ToString()
        {
            return $"Customer not available.";
        }
    }
}