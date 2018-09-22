using Simba.Contracts;
using System;

namespace Simba.Implementations.BaseElements
{
    public class SimpleText : ILatexElement
    {
        protected readonly string Text;

        public SimpleText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            Text = text;
        }

        public string GetLatex()
        {
            return Text;
        }
    }
}