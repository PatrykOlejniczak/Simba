using Simba.Contracts;
using Simba.Exceptions;
using Simba.Types;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simba.Implementations.Containers
{
    public class Tabular : BaseStructure<TabularRow<ILatexElement>>
    {
        protected override string BeginMacroValue => "tabular";
        protected override string EndMacroValue => "tabular";
        protected override string ElementSeparatorMacro => "\\hline";

        private List<Alligment> _columnAlligments;

        public Tabular()
        { }

        public Tabular(List<Alligment> columnAlligments)
        {
            _columnAlligments = columnAlligments;
        }

        public override void AddElement(TabularRow<ILatexElement> element)
        {
            if (_columnAlligments == null)
            {
                _columnAlligments = Enumerable.Repeat(Alligment.Center, element.Elements.Count).ToList();
            }
            else if (_columnAlligments.Count != element.Elements.Count)
            {
                throw new IncompatibleNumberOfColumnsException(nameof(element));
            }

            base.AddElement(element);
        }

        public override string GetLatex()
        {
            var latex = new StringBuilder(BeginMacro);
            latex.AppendLine(ConfigurationToLatex());
            for (int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(ElementSeparatorMacro);
                latex.AppendLine(Elements[index].GetLatex());
            }
            latex.AppendLine(ElementSeparatorMacro);
            latex.Append(EndMacro);

            return latex.ToString();
        }

        //TODO Should be extracted from this class
        private string ConfigurationToLatex()
        {
            var separator = '|';

            var latex = new StringBuilder().Append('{');
            foreach (var alligment in _columnAlligments)
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