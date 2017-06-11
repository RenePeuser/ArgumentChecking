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


    public class Argument<T>
    {
        public Argument(Expression<Func<T>> expression)
        {
            ArgumentExpression = expression;
            CompiledExpression = expression.Compile();
            ArgumentName = expression.NameOf();
            Value = CompiledExpression.Invoke().As<T>();
        }

        public Expression<Func<T>> ArgumentExpression { get; }

        public Func<T> CompiledExpression { get; }

        public string ArgumentName { get; }

        public T Value { get; }
    }
}