namespace ArgumentChecking.Test
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

        public static void SingleStringEmpty(string name)
        {
            ArgumentChecker.Check(() => name).IsEmpty();
        }

        public static void SingleWhitespaceEmpty(string name)
        {
            ArgumentChecker.Check(() => name).IsWhitespace();
        }

        public static void SingleIsValidString(string name)
        {
            ArgumentChecker.Check(() => name).IsValidString();
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

        public static void SingleStringEmpty(string name)
        {
            ArgumentChecker.CheckLazy(() => name).IsEmpty().Evaluate();
        }

        public static void SingleWhitespaceEmpty(string name)
        {
            ArgumentChecker.CheckLazy(() => name).IsWhitespace().Evaluate();
        }

        public static void SingleIsValidString(string name)
        {
            ArgumentChecker.CheckLazy(() => name).IsValidString().Evaluate();
        }
    }
}
