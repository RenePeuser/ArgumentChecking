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

    public interface IValidator
    {
    }

    public class Validator<T>
    {
        public Validator(string message, Func<Argument<T>, bool> selector)
        {
            Message = message;
            Selector = selector;
        }

        public string Message { get; }

        public Func<Argument<T>, bool> Selector { get; }

        public bool Validate(Argument<T> argument)
        {
            return Selector(argument);
        }
    }
}