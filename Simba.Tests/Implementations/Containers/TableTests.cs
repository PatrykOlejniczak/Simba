using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Utils;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class TableTests
    {
        [Fact]
        public void GetLatex_Table_CorrectGenerateLatexCode()
        {
            var table = new Table();
            var tabular = new Tabular();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);
            table.AddElement(tabular);

            AssertExtensions.CompareLatex(table.GetLatex(),
                                         @"\begin{table}
                                                \begin{tabular}{|c|}
                                                    \hline
                                                        New element \\
                                                    \hline
                                                \end{tabular}
                                            \end{table}");
        }
    }
}