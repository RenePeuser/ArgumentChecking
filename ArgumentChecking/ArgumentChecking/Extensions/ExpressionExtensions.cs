using System;
using System.Linq.Expressions;

namespace ArgumentChecking.Extensions
{
    public static class ExpressionExtensions
    {
        public static string NameOf(this Expression expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            var lambdaExpression = expression as LambdaExpression;
            if (lambdaExpression == null)
            {
                throw new ArgumentException("Expression is not a LambdaExpression");
            }

            string name = null;

            var memberExpression = lambdaExpression.Body as MemberExpression;
            if (memberExpression != null)
            {
                name = memberExpression.Member.Name;
            }

            var unaryExpression = lambdaExpression.Body as UnaryExpression;
            if (unaryExpression != null)
            {
                var member = unaryExpression.Operand as MemberExpression;
                if (member != null)
                {
                    name = member.Member.Name;
                }
            }

            var methodCallExpression = lambdaExpression.Body as MethodCallExpression;
            if (methodCallExpression != null)
            {
                name = methodCallExpression.Method.Name;
            }

            if (name == null)
            {
                throw new ArgumentException("Unknown expression type for extracting name.", "expression");
            }

            return name;
        }
    }
}
