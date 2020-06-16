using System;
using System.Collections.Generic;
using System.Text;

namespace Quack.FBR.Contracts
{
    /// <summary>
    /// Metadata associated with a rule
    /// </summary>
    public interface IRuleMetaData
    {
        /// <summary>
        /// Rule's CLR type.
        /// </summary>
        Type RuleType { get; }

        /// <summary>
        /// Rule's name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Rule's description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Tags applied to the rule.
        /// </summary>
        string[] Tags { get; }
    }
}

