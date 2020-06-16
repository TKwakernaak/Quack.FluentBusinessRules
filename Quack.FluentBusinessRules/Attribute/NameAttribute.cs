using System;

namespace Quack.FluentBusinessRules
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string value)
        {
            Value = value;
        }

        internal string Value { get; }
    }
}