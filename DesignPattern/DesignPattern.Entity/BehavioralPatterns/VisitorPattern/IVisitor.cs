namespace DesignPattern.Entity.BehavioralPatterns.VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Printer printer);
    }
}