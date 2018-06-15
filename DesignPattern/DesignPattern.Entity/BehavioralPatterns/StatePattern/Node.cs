namespace DesignPattern.Entity.BehavioralPatterns.StatePattern
{
    public class Node
    {
        private readonly string _name;

        public Node(string name)
        {
            _name = name;
        }

        public Node Next { get; set; }

        public override string ToString()
        {
            return _name;
        }
    }
}