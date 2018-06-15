using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DesignPattern.Entity.CreationalPatterns.SingletonPattern;

namespace DesignPattern.BLL.CreationalPatterns.SingletonPattern
{
    public class MessageLogger : TextWriter
    {
        private readonly TextWriter _consoleTextWriter = Console.Out;
        private readonly List<Message> _messageLogs = new List<Message>();
        public static MessageLogger Instance { get; } = new MessageLogger();
        public override Encoding Encoding => Encoding.UTF8;

        public override void WriteLine(string value)
        {
            base.WriteLine("\t\t" + value);
            _consoleTextWriter.WriteLine("\t\t" + value);
            _messageLogs.Add(new Message(value, DateTime.Now));
        }

        public void Start()
        {
            Console.WriteLine("\tMessageLogger Started...\n");
            Console.SetOut(this);
        }

        public void Stop()
        {
            Console.SetOut(_consoleTextWriter);
            Console.WriteLine("\n\tMessageLogger Stopped...\n");
        }

        public void DisplayLogs()
        {
            foreach (var messageLog in _messageLogs) Console.WriteLine("\t" + messageLog);
        }
    }
}