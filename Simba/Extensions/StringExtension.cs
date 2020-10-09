using System.Text;

namespace Simba.Extensions
{
    internal static class StringExtension
    {
        internal static StringBuilder AppendIsolate(this StringBuilder builder, string macro)
        {
            return builder.Append($" {macro} ");
        }
    }
}
