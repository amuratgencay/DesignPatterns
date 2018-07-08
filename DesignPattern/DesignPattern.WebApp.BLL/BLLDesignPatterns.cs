using System.Linq;
using DesignPattern.BLL.DesignPatterns;
using DesignPattern.WebApp.Entity;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.BLL
{
    public class BllDesignPatterns : IBllDesignPatterns
    {
        public VmCreationalDesignPatterns GetCreationalDesignPatterns()
        {
            var bll = new DesignPatternManager();
            var number = 1;
            var res = new VmCreationalDesignPatterns
            {
                CreationalDesignPatterns = bll.CreationalPatterns
                    .Select(x => new VmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public VmStructuralDesignPatterns GetStructuralDesignPatterns()
        {
            var bll = new DesignPatternManager();
            var number = 1;
            var res = new VmStructuralDesignPatterns
            {
                StructuralDesignPatterns = bll.CreationalPatterns
                    .Select(x => new VmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public VmBehavioralDesignPatterns GetBehavioralDesignPatterns()
        {
            var bll = new DesignPatternManager();
            var number = 1;
            var res = new VmBehavioralDesignPatterns
            {
                BehavioralDesignPatterns = bll.CreationalPatterns
                    .Select(x => new VmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public VmDesignPatterns GetDesignPatterns()
        {
            var res = new VmDesignPatterns
            {
                CreationalDesignPatterns = GetCreationalDesignPatterns(),
                StructuralDesignPatterns = GetStructuralDesignPatterns(),
                BehavioralDesignPatterns = GetBehavioralDesignPatterns()
            };
            return res;
        }
    }
}