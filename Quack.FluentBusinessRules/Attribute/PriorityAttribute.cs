using System;

namespace Quack.FluentBusinessRules
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class PriorityAttribute : Attribute
    {
        internal readonly int Value;

        public PriorityAttribute(int value)
        {
            Value = value;
        }
    }
}