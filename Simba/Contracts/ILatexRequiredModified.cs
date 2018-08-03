using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexRequiredModified : ILatexElement
    {
        IReadOnlyList<ILatexElement> RequiredModifiers { get; }
    }
}