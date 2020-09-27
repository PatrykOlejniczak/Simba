using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Utils;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class TabularRowTests
    {
        [Fact]
        public void GetLatex_TabularRowWithSingleElement_CorrectGenerateLatexCode()
        {
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));

            AssertExtensions.CompareLatex(row.GetLatex(), @"New element \\");
        }

        [Fact]
        public void GetLatex_TabularRowWithMultipleElement_CorrectGenerateLatexCode()
        {
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element v1"));
            row.AddElement(new SimpleText("New element v2"));

            AssertExtensions.CompareLatex(row.GetLatex(), @"New element v1 & New element v2 \\");
        }
    }
}