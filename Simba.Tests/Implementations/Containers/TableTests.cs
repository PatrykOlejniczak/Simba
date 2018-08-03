using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Extensions;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class TableTests
    {
        [Fact]
        public void GetLatex_Table_CorrectGenerateLatexCode()
        {
            var table = new Table<Tabular<TabularRow<ILatexElement>>>();
            var tabular = new Tabular<TabularRow<ILatexElement>>();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);
            table.AddElement(tabular);

            AssertExtensions.CompareLatex(table.GetLatex(),
                                         @"\begin{table}
                                                \begin{tabular}
                                                    \hline
                                                        New element \\
                                                    \hline
                                                \end{tabular}
                                            \end{table}");
        }
    }
}