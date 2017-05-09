using System;

namespace ArgumentChecking
{
    internal static class TcObjectExtensions
    {
        public static T As<T>(this object source)
        {
            T result = default(T);

            if (source is T)
            {
                result = (T)source;
            }

            return result;
        }
    }
}