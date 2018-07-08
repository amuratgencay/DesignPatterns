using System;
using System.Collections.Generic;

namespace DesignPattern.WebApp.Entity
{
    [Serializable]
    public class VmDesignPattern
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    [Serializable]
    public class VmCreationalDesignPatterns
    {
        public List<VmDesignPattern> CreationalDesignPatterns { get; set; }
    }

    [Serializable]
    public class VmStructuralDesignPatterns
    {
        public List<VmDesignPattern> StructuralDesignPatterns { get; set; }
    }

    [Serializable]
    public class VmBehavioralDesignPatterns
    {
        public List<VmDesignPattern> BehavioralDesignPatterns { get; set; }
    }

    [Serializable]
    public class VmDesignPatterns
    {
        public VmCreationalDesignPatterns CreationalDesignPatterns { get; set; }
        public VmStructuralDesignPatterns StructuralDesignPatterns { get; set; }
        public VmBehavioralDesignPatterns BehavioralDesignPatterns { get; set; }
    }
}