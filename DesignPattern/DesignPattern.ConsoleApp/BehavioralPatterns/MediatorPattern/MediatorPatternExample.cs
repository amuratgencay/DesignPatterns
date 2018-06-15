using System;
using DesignPattern.BLL.BehavioralPatterns.MediatorPattern;
using DesignPattern.Entity.BehavioralPatterns.MediatorPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.MediatorPattern
{
    public static class MediatorPatternExample
    {
        public static void Run()
        {
            var chatRoom = new ChatRoom();
            var john = new Participant("John");
            var paul = new Participant("Paul");
            var ringo = new Participant("Ringo");
            var george = new Participant("George");
            chatRoom.Register(john, paul, ringo, george);
            Console.WriteLine("<Mediator Pattern Example>");
            Console.WriteLine();
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Paul", "My sweet love");
            Console.WriteLine();
            Console.WriteLine("</Mediator Pattern Example>");
            Console.WriteLine();
        }
    }
}