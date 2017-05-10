using ArgumentChecking.Extensions;

namespace ArgumentChecking.Validation
{
    public class IsStringEmptyValidator : Validator
    {
        public IsStringEmptyValidator() : base("Following arguments are string empty:", arg => arg.Value.EqualsTo(string.Empty))
        {
        }
    }
}