using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgumentChecking.Validation;

namespace ArgumentChecking
{
    public static class LazyArgumentRepositoryExtensions
    {
        public static LazyArgumentRepository IsNull(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.Add(new IsNullValidator());
            return source;
        }

        public static LazyArgumentRepository IsEmpty(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.Add(new IsStringEmptyValidator());
            return source;
        }

        public static void Evaluate(this LazyArgumentRepository source)
        {
            var stringBuilder = new StringBuilder();

            foreach (var validator in source.Validators())
            {
                var argumentFailing = new List<Argument>();
                foreach (var argument in source.Arguments)
                {
                    if (validator.Validate(argument))
                    {
                        argumentFailing.Add(argument);
                    }
                }

                if (argumentFailing.Any())
                {
                    stringBuilder.AppendLine($"{validator.Message}\n{argumentFailing.ToMessage()}");
                }
            }

            var result = stringBuilder.ToString();
            if (!string.IsNullOrEmpty(result))
            {
                throw new ArgumentException(result);
            }
        }
    }
}