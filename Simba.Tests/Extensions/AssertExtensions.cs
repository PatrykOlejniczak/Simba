using System;
using System.Linq;
using Xunit;

namespace Simba.Tests.Extensions
{
    public static class AssertExtensions
    {
        public static void CompareLatex(string expected, string actual)
        {
            var normalizeExpected
                    = new string(expected.Where(c => Char.IsWhiteSpace(c) == false).ToArray());
            var normalizeActual
                    = new string(actual.Where(c => Char.IsWhiteSpace(c) == false).ToArray());

            Assert.Equal(normalizeExpected, normalizeActual);
        }
    }
}
