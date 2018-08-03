using System.Text;
using Simba.Contracts;

namespace Simba.Implementations.Containers
{
    public abstract class BaseStructure<T> : BaseContainer<T> where T : ILatexElement
    {
        protected abstract string BeginMacroValue { get; }
        protected abstract string EndMacroValue { get; }

        private string BeginMacro => $"\\begin{{{BeginMacroValue}}}";
        private string EndMacro => $"\\end{{{EndMacroValue}}}";

        public override string GetLatex()
        {
            var latex = new StringBuilder(BeginMacro);
            for (int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(ElementSeparatorMacro);
                latex.AppendLine(Elements[index].GetLatex());
            }
            latex.AppendLine(ElementSeparatorMacro);
            latex.AppendLine(EndMacro);

            return latex.ToString();
        }
    }
}