using System.Collections.Generic;
using System.Text;
using ArgumentChecking.Extensions;

namespace ArgumentChecking
{
    public static class ArgumentExtensions
    {
        public static string ToMessage(this IEnumerable<Argument> arguments)
        {
            var stringBuilder = new StringBuilder();
            arguments.ForEach(item => stringBuilder.AppendLine(item.ArgumentName));
            return stringBuilder.ToString();
        }
    }
}
