using System.Collections.Generic;

namespace ArgumentChecking.Extensions
{
    internal static class GenericTypeExtensions
    {
        public static bool EqualsTo<T>(this T source, T target)
        {
            return EqualityComparer<T>.Default.Equals(source, target);
        }
    }
}