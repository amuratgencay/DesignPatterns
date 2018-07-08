using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.WebApp.Entity;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.BLL
{
    public class BLLDesignPatterns : IBLLDesignPatterns
    {
        public vmCreationalDesignPatterns GetCreationalDesignPatterns()
        {
            var bll = new DesignPattern.BLL.DesignPatterns.DesignPatternManager();
            var number = 1;
            var res = new vmCreationalDesignPatterns
            {
                CreationalDesignPatterns = bll.CreationalPatterns
                    .Select(x => new vmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public vmStructuralDesignPatterns GetStructuralDesignPatterns()
        {
            var bll = new DesignPattern.BLL.DesignPatterns.DesignPatternManager();
            var number = 1;
            var res = new vmStructuralDesignPatterns
            {
                StructuralDesignPatterns = bll.CreationalPatterns
                    .Select(x => new vmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public vmBehavioralDesignPatterns GetBehavioralDesignPatterns()
        {
            var bll = new DesignPattern.BLL.DesignPatterns.DesignPatternManager();
            var number = 1;
            var res = new vmBehavioralDesignPatterns
            {
                BehavioralDesignPatterns = bll.CreationalPatterns
                    .Select(x => new vmDesignPattern {Name = x, Url = x, Number = number++}).ToList()
            };

            return res;
        }

        public vmDesignPatterns GetDesignPatterns()
        {
            var res = new vmDesignPatterns
            {
                CreationalDesignPatterns = GetCreationalDesignPatterns(),
                StructuralDesignPatterns = GetStructuralDesignPatterns(),
                BehavioralDesignPatterns = GetBehavioralDesignPatterns()
            };
            return res;
        }
    }
}
