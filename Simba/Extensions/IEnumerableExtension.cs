using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using System.Collections.Generic;

namespace Simba.Extensions
{
    public static class EnumerableExtension
    {
        public static string ToLatex<T>(this IEnumerable<T> collection)
        {
            var latexTable = new Table();
            var latexTabular = new Tabular();
            foreach (var element in collection)
            {
                var latexRow = new TabularRow<ILatexElement>();
                foreach (var property in typeof(T).GetProperties())
                {
                    var latexElement = new SimpleText(property.GetValue(element).ToString());
                    latexRow.AddElement(latexElement);
                }

                latexTabular.AddElement(latexRow);
            }
            latexTable.AddElement(latexTabular);

            return latexTable.GetLatex();
        }
    }
}