using Simba.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simba.Exceptions;
using Simba.Types;

namespace Simba.Implementations.Containers
{
    public class Tabular : BaseStructure<TabularRow<ILatexElement>>
    {
        protected override string BeginMacroValue => "tabular";
        protected override string EndMacroValue => "tabular";
        protected override string ElementSeparatorMacro => "\\hline";

        private List<Alligment> columnAlligments;

        public Tabular()
        { }

        public Tabular(List<Alligment> columnAlligments)
        {
            this.columnAlligments = columnAlligments;
        }

        public override void AddElement(TabularRow<ILatexElement> element)
        {
            if (columnAlligments == null)
            {
                columnAlligments = Enumerable.Repeat(Alligment.Center, element.Elements.Count).ToList();
            }
            else if (columnAlligments.Count != element.Elements.Count)
            {
                throw new IncompatibleNumberOfColumnsException(nameof(element));
            }

            base.AddElement(element);
        }

        public override string GetLatex()
        {
            var latex = new StringBuilder(BeginMacro);
            latex.Append(ConfigurationToLatex());
            for (int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(ElementSeparatorMacro);
                latex.AppendLine(Elements[index].GetLatex());
            }
            latex.AppendLine(ElementSeparatorMacro);
            latex.AppendLine(EndMacro);

            return latex.ToString();
        }

        private string ConfigurationToLatex()
        {
            var separator = '|';

            var latex = new StringBuilder().Append('{');
            foreach (var alligment in columnAlligments)
            {
                latex.Append(separator);
                latex.Append((char)alligment);
            }
            latex.Append(separator);
            latex.Append('}');

            return latex.ToString();
        }
    }
}