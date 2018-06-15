﻿using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.BLL.BehavioralPatterns.InterpreterPattern
{
    public class OneExpression : Expression
    {
        protected override string One()
        {
            return "I";
        }

        protected override string Four()
        {
            return "IV";
        }

        protected override string Five()
        {
            return "V";
        }

        protected override string Nine()
        {
            return "IX";
        }

        protected override int Multiplier()
        {
            return 1;
        }
    }
}