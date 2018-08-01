using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexModifiedElement : ILatexElement
    {
        ICollection<ILatexElement> Modifiers { get; }
    }
}