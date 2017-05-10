using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArgumentChecking.Validation;

namespace ArgumentChecking
{
    public static class LazyLazyArgumentRepositoryExtensions
    {
        public static LazyArgumentRepository IsNull(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.AddValidator(new IsNullValidator());
            return source;
        }

        public static LazyArgumentRepository IsEmpty(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.AddValidator(new IsStringEmptyValidator());
            return source;
        }

        public static LazyArgumentRepository IsWhitespace(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.AddValidator(new IsStringWhitespaceValidator());
            return source;
        }

        public static LazyArgumentRepository IsValidString(this LazyArgumentRepository source)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            source.AddValidator(new IsNullValidator());
            source.AddValidator(new IsStringEmptyValidator());
            source.AddValidator(new IsStringWhitespaceValidator());
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