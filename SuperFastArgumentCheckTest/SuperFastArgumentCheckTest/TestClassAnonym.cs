namespace ArgumentCheck.Test
{
    public class TestClassAnonym
    {
        public string Name { get; }

        public TestClassAnonym(string name)
        {
            Expect.NotNullAnonym(new { name });

            Name = name;
        }
    }

    public class TestClassUltra
    {
        public string Name { get; set; }

        public TestClassUltra(string name)
        {
            Name = name;
        }
    }
}