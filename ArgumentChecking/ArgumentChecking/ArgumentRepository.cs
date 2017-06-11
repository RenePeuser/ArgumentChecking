using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ArgumentChecking
{
    public class ArgumentRepository
    {
        public ArgumentRepository(IEnumerable<Expression<Func<object>>> expressions)
        {
            Arguments = expressions.Select(item => new Argument(item)).ToArray();
        }

        public Argument[] Arguments { get; }
    }
}