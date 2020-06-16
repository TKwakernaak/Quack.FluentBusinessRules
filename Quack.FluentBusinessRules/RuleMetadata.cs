using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Quack.FBR.Contracts;

namespace Quack.FluentBusinessRules
{
    public class RuleMetadata : IRuleMetaData
    {
        public RuleMetadata(Type ruleType)
        {
            RuleType = ruleType;
            Name = GetAttributes<NameAttribute>().Select(a => a.Value).SingleOrDefault() ?? RuleType.FullName;
            Description = GetAttributes<DescriptionAttribute>().Select(a => a.Value).SingleOrDefault() ?? string.Empty;
            Tags = GetAttributes<TagAttribute>().Select(a => a.Value).ToArray();
            Priority = GetAttributes<PriorityAttribute>().Select(a => a.Value).SingleOrDefault();
        }

        /// <summary>
        /// Rule's CLR type.
        /// </summary>
        public Type RuleType { get; }

        /// <summary>
        /// Rule's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Rule's description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Tags applied to the rule.
        /// </summary>
        public string[] Tags { get; }

        /// <summary>
        /// Rule's priority.
        /// </summary>
        public int? Priority { get; }


        private T[] GetAttributes<T>() where T : Attribute
        {
            var typeInfo = RuleType.GetTypeInfo();
            return typeInfo.GetCustomAttributes(true).OfType<T>().ToArray();
        }
    }
}

