using Simba.Contracts;
using Simba.Extensions;
using System.Text;

namespace Simba.Implementations.Containers
{
    public class TabularRow<T> : BaseContainer<T>
        where T : ILatexElement
    {
        protected override string ElementSeparatorMacro => "&";
        
        private string _endRowMacro => "\\\\";

        public override string GetLatex()
        {
            var latex = new StringBuilder();
            for (int index = 0; index < Elements.Count; index++)
            {
                latex.Append(Elements[index].GetLatex());

                if (index != Elements.Count - 1)
                {
                    latex.AppendIsolate(ElementSeparatorMacro);
                }
            }
            latex.AppendIsolate(_endRowMacro);

            return latex.ToString();
        }
    }
}