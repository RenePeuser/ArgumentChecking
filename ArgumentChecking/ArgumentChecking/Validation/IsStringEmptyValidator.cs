using ArgumentChecking.Extensions;

namespace ArgumentChecking.Validation
{
    public class IsStringEmptyValidator : Validator
    {
        public IsStringEmptyValidator() : base("Following arguments are NULL:", arg => arg.Value.EqualsTo((object)string.Empty))
        {
        }
    }
}