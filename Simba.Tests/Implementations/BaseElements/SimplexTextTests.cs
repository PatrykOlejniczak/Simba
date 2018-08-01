using System;
using Simba.Implementations.BaseElements;
using Xunit;

namespace Simba.Tests.Implementations.BaseElements
{
    public class SimplexTextTests
    {
        [Fact]
        public void GetLatex_NullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SimpleText(null));
        }

        [Fact]
        public void GetLatex_EmptyException()
        {
            Assert.Throws<ArgumentNullException>(() => new SimpleText(""));
        }

        [Fact]
        public void GetLatex_CorrectLatexCode()
        {
            var element = new SimpleText("Simple text test!");
            var latex = element.GetLatex();

            Assert.Equal("Simple text test!", latex);
        }
    }
}