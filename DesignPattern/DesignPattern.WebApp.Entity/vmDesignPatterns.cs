using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.WebApp.Entity
{
    [Serializable]
    public class vmDesignPattern
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

    }

    [Serializable]
    public class vmCreationalDesignPatterns
    {
        public List<vmDesignPattern> CreationalDesignPatterns { get; set; }
    }

    [Serializable]
    public class vmStructuralDesignPatterns
    {
        public List<vmDesignPattern> StructuralDesignPatterns { get; set; }
    }

    [Serializable]
    public class vmBehavioralDesignPatterns
    {
        public List<vmDesignPattern> BehavioralDesignPatterns { get; set; }
    }

    [Serializable]
    public class vmDesignPatterns
    {
        public vmCreationalDesignPatterns CreationalDesignPatterns { get; set; }
        public vmStructuralDesignPatterns StructuralDesignPatterns { get; set; }
        public vmBehavioralDesignPatterns BehavioralDesignPatterns { get; set; }
    }
}
