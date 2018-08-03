using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexContainer<T>
    {
        IReadOnlyList<T> Elements { get; }

        void AddElement(T element);
    }
}