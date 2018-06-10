using System;

namespace DesignPattern.Entity.CreationalPatterns.SingletonPattern
{
    public class Message
    {
        public DateTime Time { get; set; }
        public string Value { get; set; }

        public Message(string value, DateTime time)
        {
            Time = time;
            Value = value;
        }
        public override string ToString()
        {
            return $"[{Time.ToLongTimeString() + ":" + Time.Millisecond}] = {Value}";
        }
    }
}
