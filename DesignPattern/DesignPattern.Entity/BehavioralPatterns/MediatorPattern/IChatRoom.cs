namespace DesignPattern.Entity.BehavioralPatterns.MediatorPattern
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(Participant from, Participant to, string message);
    }
}