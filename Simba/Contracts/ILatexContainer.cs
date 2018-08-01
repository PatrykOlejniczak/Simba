using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexContainer
    {
        ICollection<ILatexElement> Elements { get; }
    }
}