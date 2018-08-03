using System.Collections.Generic;
using Simba.Contracts;

namespace Simba.Implementations.Containers
{
    public class Tabular : BaseContainer, ILatexRequiredModified
    {
        protected override string BeginMacroValue => "tabular";
        protected override string EndMacroValue => "tabular";
        protected override string ElementSeparatorMacro => "\\hline";

        public IReadOnlyCollection<ILatexElement> RequiredModifiers { get; }
    }
}