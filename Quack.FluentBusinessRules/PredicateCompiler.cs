using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Quack.FluentBusinessRules
{
    public class PredicateCompiler
    {
        public Func<T, TOutput> Create<T, TOutput>(Rule rule)
        {
            var propertyType = typeof(T).GetProperty(rule.PropertyName).PropertyType;
            var genericType = Expression.Parameter(typeof(T));
            var left = Expression.Property(genericType, rule.PropertyName);
            var right = Expression.Constant(Convert.ChangeType(rule.Value, propertyType));
            var binaryExpression = Expression.MakeBinary(rule.Operator._ExpressionType, left, right);

            return Expression.Lambda<Func<T, TOutput>>(binaryExpression, genericType).Compile();
        }
    }
}
