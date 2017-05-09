using System;
using System.Linq.Expressions;
using ArgumentChecking.Extensions;

namespace ArgumentChecking
{
    public class Argument
    {
        public Argument(Expression<Func<object>> expression)
        {
            ArgumentExpression = expression;
            CompiledExpression = expression.Compile();
            ArgumentName = expression.NameOf();
            Value = CompiledExpression.Invoke().As<object>();
        }

        public Expression<Func<object>> ArgumentExpression { get; }

        public Func<object> CompiledExpression { get; }

        public string ArgumentName { get; }

        public object Value { get; }
    }
}