using Simba.Contracts;

namespace Simba.Implementations.Containers
{
    public class Table<T> : BaseStructure<T> where T : Tabular<TabularRow<ILatexElement>>
    {
        protected override string BeginMacroValue => "table";
        protected override string EndMacroValue => "table";
        protected override string ElementSeparatorMacro => string.Empty;
    }
}