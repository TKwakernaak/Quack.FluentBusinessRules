using System;

namespace Quack.FluentBusinessRules
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class RepeatabilityAttribute : Attribute
    {
    }
}