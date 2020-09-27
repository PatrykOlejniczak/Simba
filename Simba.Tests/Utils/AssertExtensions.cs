using System.Linq;
using Xunit;

namespace Simba.Tests.Utils
{
    public static class AssertExtensions
    {
        public static void CompareLatex(string actual, string expected)
        {
            var normalizeExpected
                    = new string(expected.Where(c => char.IsWhiteSpace(c) == false).ToArray());
            var normalizeActual
                    = new string(actual.Where(c => char.IsWhiteSpace(c) == false).ToArray());

            Assert.Equal(normalizeExpected, normalizeActual);
        }
    }
}
