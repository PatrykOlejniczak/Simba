using System.Text;

namespace Simba.Extensions
{
    public static class StringExtension
    {
        public static StringBuilder AppendIsolate(this StringBuilder builder, string macro)
        {
            return builder.Append($" {macro} ");
        }
    }
}
