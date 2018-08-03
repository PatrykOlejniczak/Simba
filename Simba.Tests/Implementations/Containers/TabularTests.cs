using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Extensions;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class TabularTests
    {
        [Fact]
        public void GetLatex_TabularWithSingleElement_CorrectGenerateLatexCode()
        {
            var tabular = new Tabular<TabularRow<ILatexElement>>();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                          @"\begin{tabular}
                                                \hline
                                                    New element \\
                                                \hline
                                            \end{tabular}");
        }

        [Fact]
        public void GetLatex_TabularWithMultipleElement_CorrectGenerateLatexCode()
        {
            var tabular = new Tabular<TabularRow<ILatexElement>>();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                          @"\begin{tabular}
                                                \hline
                                                    New element \\
                                                \hline
                                                    New element \\
                                                \hline
                                            \end{tabular}");
        }
    }
}