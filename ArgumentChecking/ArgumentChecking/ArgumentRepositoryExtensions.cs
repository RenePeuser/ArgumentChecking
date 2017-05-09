using System;
using System.Linq;
using ArgumentChecking.Validation;

namespace ArgumentChecking
{
    public static class ArgumentRepositoryExtensions
    {
        public static void IsNull(this ArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            Evaluate(source, new IsNullValidator());
        }

        public static void IsEmpty(this ArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            Evaluate(source, new IsStringEmptyValidator());
        }

        private static void Evaluate(this ArgumentRepository source, Validator validator)
        {
            var errors = source.Arguments.Where(validator.Validate);
            if (errors.Any())
            {
                throw new ArgumentException($"{validator.Message}\n{errors.ToMessage()}");
            }
        }
    }
}