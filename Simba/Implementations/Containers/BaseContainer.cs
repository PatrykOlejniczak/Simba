using System;
using Simba.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Simba.Implementations.Containers
{
    public abstract class BaseContainer : ILatexContainer, ILatexElement
    {
        public IReadOnlyCollection<ILatexElement> Elements => elements.AsReadOnly();

        protected readonly List<ILatexElement> elements;
        protected abstract string BeginMacroValue { get; }
        protected abstract string EndMacroValue { get; }
        protected abstract string ElementSeparatorMacro { get; }

        private string BeginMacro => $"\\begin{{{BeginMacroValue}}}";
        private string EndMacro => $"\\end{{{EndMacroValue}}}";

        protected BaseContainer()
        {
            elements = new List<ILatexElement>();
        }

        public virtual void AddElement(ILatexElement element)
        {
            elements.Add(element);
        }

        public virtual string GetLatex()
        {
            CheckStructureCorrectness();

            var latex = new StringBuilder(BeginMacro);
            for(int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(ElementSeparatorMacro);
                latex.AppendLine(elements[index].GetLatex());
            }
            latex.AppendLine(ElementSeparatorMacro);
            latex.AppendLine(EndMacro);

            return latex.ToString();
        }

        protected virtual bool CheckStructureCorrectness()
        {
            return true;
        }
    }
}