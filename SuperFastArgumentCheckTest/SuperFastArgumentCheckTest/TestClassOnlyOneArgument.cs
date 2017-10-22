namespace ArgumentCheck.Test
{
    public class TestClassOnlyOneArgument
    {
        public string Name { get; }

        public TestClassOnlyOneArgument(string name)
        {
            Name = name.NotNullOneParam();
        }
    }
}