using System;

namespace Quack.FluentBusinessRules
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class DescriptionAttribute : Attribute
    {
        public DescriptionAttribute(string value)
        {
            Value = value;
        }

        internal string Value { get; }
    }
}