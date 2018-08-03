namespace Simba.Implementations.Containers
{
    public class Table : BaseContainer
    {
        protected override string BeginMacroValue => "table";
        protected override string EndMacroValue => "table";
        protected override string ElementSeparatorMacro => string.Empty;
    }
}