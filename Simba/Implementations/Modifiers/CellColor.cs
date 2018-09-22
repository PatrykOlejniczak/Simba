using Simba.Contracts;
using System.Globalization;

namespace Simba.Implementations.Modifiers
{
    public class CellColor : ILatexElement
    {
        private ColorRgb color;

        public CellColor(ColorRgb color)
        {
            this.color = color;
        }

        public string GetLatex()
        {
            return $"\\cellcolor[rgb]{{{color.Red.ToString(CultureInfo.InvariantCulture)},{color.Green.ToString(CultureInfo.InvariantCulture)},{color.Blue.ToString(CultureInfo.InvariantCulture)}}}";
        }
    }
}