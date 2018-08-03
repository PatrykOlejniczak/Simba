using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexOptionalModified : ILatexElement
    {
        IReadOnlyList<ILatexElement> OptionalModified { get; }
    }
}