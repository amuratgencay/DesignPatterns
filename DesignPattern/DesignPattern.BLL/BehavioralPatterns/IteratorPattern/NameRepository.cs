using System.Collections.Generic;
using DesignPattern.Entity.BehavioralPatterns.IteratorPattern;

namespace DesignPattern.BLL.BehavioralPatterns.IteratorPattern
{
    public class NameRepository
    {
        private readonly Container<string> _names = new Container<string>(new List<string>
        {
            "Robert",
            "John",
            "Juile",
            "Lora"
        });

        public IIterator<string> GetIterator()
        {
            return _names.GetIterator();
        }
    }
}