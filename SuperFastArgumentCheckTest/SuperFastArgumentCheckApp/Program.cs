using SuperFastArgumentCheck;

namespace SuperFastArgumentCheckApp
{
    class Program
    {
        static void Main()
        {
            var a = new Person("a", null, "c", null);
        }


        public class Person
        {
            public Person(string name, string dateTime, string next, string emptyValue)
            {
                Expect.NotNull(() => dateTime);
                Expect.NotNull(() => name);
                Expect.NotNull(() => next);
                Expect.IsEmpty(() => emptyValue);
            }
        }

    }
}