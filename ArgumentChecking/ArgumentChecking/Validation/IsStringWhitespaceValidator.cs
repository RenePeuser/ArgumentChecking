using ArgumentChecking.Extensions;

namespace ArgumentChecking.Validation
{
    public class IsStringWhitespaceValidator : Validator
    {
        public IsStringWhitespaceValidator() : base("Following arguments are whitespaces:", arg => arg.Value.EqualsTo(" "))
        {
        }
    }
}