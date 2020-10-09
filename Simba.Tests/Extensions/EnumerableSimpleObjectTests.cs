using Simba.Extensions;
using System.Collections.Generic;
using Xunit;

namespace Simba.Tests
{
    public class EnumerableSimpleObjectTests
    {
        [Fact]
        public void ToLatex_ReturnCorrectTable_ForSingleElement()
        {
            var persons = new List<MockPerson>()
            {
                new MockPerson("John", "Smith", 18),
                new MockPerson("John", "Smith", 18)
            };

            var latex = persons.ToLatex();
        }

        private class MockPerson
        {
            public MockPerson(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public string FirstName { get; }
            public string LastName { get; }
            public int Age { get; }
        }
    }
}
