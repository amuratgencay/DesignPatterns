using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DesignPattern.Entity.SingletonPattern;

namespace DesignPattern.BLL.SingletonPattern
{
    public class MessageLogger : TextWriter
    {
        private static readonly  MessageLogger _instance = new MessageLogger();
        private readonly List<Message> _messageLogs = new List<Message>();
        private readonly TextWriter _consoleTextWriter = Console.Out;
        public static MessageLogger Instance => _instance;
        public override Encoding Encoding => System.Text.Encoding.UTF8;

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
            foreach (var messageLog in _messageLogs)
            {
                Console.WriteLine("\t" + messageLog);
            }
        }
    }
}
