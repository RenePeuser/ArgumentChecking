namespace ArgumentChecking.Validation
{
    public class IsNullValidator : Validator
    {
        public IsNullValidator() : base("Following arguments are NULL:", arg => arg.Value == null)
        {
        }
    }
}