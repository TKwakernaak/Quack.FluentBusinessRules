using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Quack.FluentBusinessRules
{
    public class Rule
    {
        public string PropertyName { get; }

        public Operator Operator { get; }

        public object Value { get; }

        public Rule(string propertyName, Operator @operator, object value)
        {
            PropertyName = propertyName;
            Operator = @operator;
            Value = value;
        }
    }

    public class Operator
    {
        public ExpressionType _ExpressionType { get; }

        public Operator(ExpressionType type)
        {
            _ExpressionType = type;
        }
    }
}
