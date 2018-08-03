using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexOptionalModified : ILatexElement
    {
        IReadOnlyCollection<ILatexElement> OptionalModified { get; }
    }
}