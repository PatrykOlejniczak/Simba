using System.Collections.Generic;
using Simba.Contracts;
using Simba.Exceptions;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Utils;
using Simba.Types;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class TabularTests
    {
        [Fact]
        public void GetLatex_TabularWithSingleRow_CorrectGenerateLatexCode()
        {
            var tabular = new Tabular();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                          @"\begin{tabular}{|c|}
                                                \hline
                                                    New element \\
                                                \hline
                                            \end{tabular}");
        }

        [Fact]
        public void GetLatex_TabularWithMultipleRows_CorrectGenerateLatexCode()
        {
            var tabular = new Tabular();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                          @"\begin{tabular}{|c|}
                                                \hline
                                                    New element \\
                                                \hline
                                                    New element \\
                                                \hline
                                            \end{tabular}");
        }

        [Fact]
        public void GetLatex_TabularWithMultipleColumn_DefaultConfiguration()
        {
            var tabular = new Tabular();
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element v1"));
            row.AddElement(new SimpleText("New element v2"));
            tabular.AddElement(row);
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                         @"\begin{tabular}{|c|c|}
                                                \hline
                                                    New element v1 & New element v2 \\
                                                \hline
                                                    New element v1 & New element v2 \\
                                                \hline
                                            \end{tabular}");
        }

        [Fact]
        public void GetLatex_TabularWithMultipleColumn_CustomConfiguration()
        {
            var configuration = new List<Alligment>() { Alligment.Left, Alligment.Right };

            var tabular = new Tabular(configuration);
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element v1"));
            row.AddElement(new SimpleText("New element v2"));
            tabular.AddElement(row);
            tabular.AddElement(row);

            AssertExtensions.CompareLatex(tabular.GetLatex(),
                                        @"\begin{tabular}{|l|r|}
                                                \hline
                                                    New element v1 & New element v2 \\
                                                \hline
                                                    New element v1 & New element v2 \\
                                                \hline
                                            \end{tabular}");
        }

        [Fact]
        public void AddElement_DefaultConfiguration_ThrowIncompatibleNumberOfColumns()
        {
            var tabular = new Tabular();
            var row = new TabularRow<ILatexElement>();
            var emptyRow = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));
            tabular.AddElement(row);

            Assert.Throws<IncompatibleNumberOfColumnsException>(() => tabular.AddElement(emptyRow));
        }

        [Fact]
        public void AddElement_CustomConfiguration_ThrowIncompatibleNumberOfColumns()
        {
            var configuration = new List<Alligment>() { Alligment.Left, Alligment.Right };

            var tabular = new Tabular(configuration);
            var row = new TabularRow<ILatexElement>();
            row.AddElement(new SimpleText("New element"));

            Assert.Throws<IncompatibleNumberOfColumnsException>(() => tabular.AddElement(row));
        }
    }
}