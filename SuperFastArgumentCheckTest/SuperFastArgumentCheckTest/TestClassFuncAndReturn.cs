namespace ArgumentCheck.Test
{
    public class TestClassFuncAndReturn
    {
        public string Name { get; }

        public TestClassFuncAndReturn(string name)
        {
            Name = Expect.NotNull(() => name);
        }
    }
}