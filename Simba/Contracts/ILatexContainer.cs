using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexContainer
    {
        IReadOnlyCollection<ILatexElement> Elements { get; }

        void AddElement(ILatexElement element);
    }
}