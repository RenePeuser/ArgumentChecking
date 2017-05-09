namespace ArgumentChecking.Model
{
    public class DirectCheck
    {
        public static void SingleArgumentCheck(string name)
        {
            ArgumentChecker.Check(() => name).IsNull();
        }

        public static void MultipleArgumentCheck(string name, string familyName)
        {
            ArgumentChecker.Check(() => name, () => familyName).IsNull();
        }
    }

    public class CheckLazy
    {
        public static void SingleArgumentCheck(string name)
        {
            ArgumentChecker.CheckLazy(() => name).IsNull().Evaluate();
        }

        public static void MultipleArgumentCheck(string name, string familyName)
        {
            ArgumentChecker.CheckLazy(() => name, () => familyName).IsNull().Evaluate();
        }

        public static void DifferentArgumentCheck(string name, string familyName)
        {
            ArgumentChecker.CheckLazy(() => name).IsEmpty().IsNull().Evaluate();
        }
    }
}
