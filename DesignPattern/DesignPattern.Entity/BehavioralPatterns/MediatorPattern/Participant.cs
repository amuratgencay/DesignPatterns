using System;

namespace DesignPattern.Entity.BehavioralPatterns.MediatorPattern
{
    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public IChatRoom ChatRoom { get; set; }
        public string Name { get; }

        public void Send(Participant to, string message)
        {
            ChatRoom.Send(this, to, message);
        }

        public void Receive(Participant from, string message)
        {
            Console.WriteLine($"\tfrom {from} to {this}: {message}");
        }

        public static implicit operator Participant(string value)
        {
            return new Participant(value);
        }

        public static implicit operator string(Participant value)
        {
            return value.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}