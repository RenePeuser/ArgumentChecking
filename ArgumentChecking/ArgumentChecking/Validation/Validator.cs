using System;

namespace ArgumentChecking.Validation
{
    public class Validator
    {
        public Validator(string message, Func<Argument, bool> selector)
        {
            Message = message;
            Selector = selector;
        }

        public string Message { get; }

        public Func<Argument, bool> Selector { get; }

        public bool Validate(Argument argument)
        {
            return Selector(argument);
        }
    }
}