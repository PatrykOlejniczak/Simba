using Simba.Contracts;
using System.Text;

namespace Simba.Implementations.Containers
{
    public class TabularRow<T> : BaseContainer<T> where T : ILatexElement
    {
        protected override string ElementSeparatorMacro => "&";
        private string endRowMacro => "\\\\";

        public override string GetLatex()
        {
            var latex = new StringBuilder();
            for (int index = 0; index < Elements.Count; index++)
            {
                latex.AppendLine(Elements[index].GetLatex());

                if (index != Elements.Count - 1)
                {
                    latex.AppendLine(ElementSeparatorMacro);
                }
            }
            latex.AppendLine(endRowMacro);

            return latex.ToString();
        }
    }
}