using System;
using System.Linq.Expressions;

namespace ArgumentChecking
{
    public static class ArgumentChecker
    {
        public static ArgumentRepository Check(params Expression<Func<object>>[] expressions)
        {
            return new ArgumentRepository(expressions);
        }

        public static LazyArgumentRepository CheckLazy(params Expression<Func<object>>[] expressions)
        {
            return new LazyArgumentRepository(expressions);
        }
    }
}
