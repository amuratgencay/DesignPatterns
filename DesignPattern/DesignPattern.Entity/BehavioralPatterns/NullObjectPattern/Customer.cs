namespace DesignPattern.Entity.BehavioralPatterns.NullObjectPattern
{
    public abstract class Customer
    {
        private static int lastId;

        protected Customer(string name)
        {
            Id = ++lastId;
            Name = name;
        }

        public string Name { get; }
        public int Id { get; }
        public abstract bool IsNull();

        public override string ToString()
        {
            return $"Customer[{Id}] -> Name: {Name}";
        }
    }
}