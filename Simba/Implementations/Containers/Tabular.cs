using Simba.Contracts;

namespace Simba.Implementations.Containers
{
    public class Tabular<T> : BaseStructure<T> where T : TabularRow<ILatexElement>
    {
        protected override string BeginMacroValue => "tabular";
        protected override string EndMacroValue => "tabular";
        protected override string ElementSeparatorMacro => "\\hline";
    }
}