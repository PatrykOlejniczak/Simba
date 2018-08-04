using Simba.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Simba.Implementations.Containers
{
    public abstract class BaseContainer<T> : ILatexContainer<T>, ILatexElement
        where T : ILatexElement
    {
        public IReadOnlyList<T> Elements => elements.AsReadOnly();

        protected abstract string ElementSeparatorMacro { get; }
        private readonly List<T> elements;

        protected BaseContainer()
        {
            elements = new List<T>();
        }

        public virtual void AddElement(T element)
        {
            elements.Add(element);
        }

        public virtual string GetLatex()
        {
            var latex = new StringBuilder();
            for(int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(ElementSeparatorMacro);
                latex.AppendLine(elements[index].GetLatex());
            }
            latex.AppendLine(ElementSeparatorMacro);

            return latex.ToString();
        }
    }
}