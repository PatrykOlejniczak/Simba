using Simba.Contracts;
using System.Globalization;

namespace Simba.Implementations.Modifiers
{
    public class CellColor : ILatexElement
    {
        private ColorRgb _color;

        public CellColor(ColorRgb color)
        {
            _color = color;
        }

        public string GetLatex()
        {
            return $"\\cellcolor[rgb]{{{_color.Red.ToString(CultureInfo.InvariantCulture)},{_color.Green.ToString(CultureInfo.InvariantCulture)},{_color.Blue.ToString(CultureInfo.InvariantCulture)}}}";
        }
    }
}