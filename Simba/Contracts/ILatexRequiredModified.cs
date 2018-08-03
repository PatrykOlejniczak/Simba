using System.Collections.Generic;

namespace Simba.Contracts
{
    public interface ILatexRequiredModified : ILatexElement
    {
        IReadOnlyCollection<ILatexElement> RequiredModifiers { get; }
    }
}