﻿using System.Collections.Generic;

namespace DesignPattern.BLL.DesignPatterns
{
    public class DesignPatternManager
    {
        public readonly List<string> BehvaioralPatterns;
        public readonly List<string> CreationalPatterns;
        public readonly List<string> StructuralPatterns;

        public DesignPatternManager()
        {
            CreationalPatterns = new List<string> {"Factory", "Abstract Factory", "Singleton", "Builder", "Prototype"};
            StructuralPatterns = new List<string>
            {
                "Adapter",
                "Bridge",
                "Decorator",
                "Facade",
                "Flyweight",
                "Composite",
                "Private Class Data",
                "Proxy"
            };
            BehvaioralPatterns = new List<string>
            {
                "Chain of Responsibility",
                "Command",
                "Interpreter",
                "Iterator",
                "Mediator",
                "Memento",
                "Observer",
                "State",
                "Strategy",
                "Template",
                "Visitor",
                "Null Object"
            };
        }
    }
}