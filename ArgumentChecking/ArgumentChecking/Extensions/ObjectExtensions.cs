namespace ArgumentChecking.Extensions
{
    internal static class ObjectExtensions
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