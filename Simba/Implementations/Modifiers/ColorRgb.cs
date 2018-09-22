using System;
using System.Globalization;
using Simba.Contracts;

namespace Simba.Implementations.Modifiers
{
    public class ColorRgb
    {
        public ColorRgb(double red, double green, double blue)
        {
            if (!CheckRange(red) || !CheckRange(green) || !CheckRange(blue))
            {
                throw new ArgumentException("Colors value should be between <0.0, 1.0>!");
            }

            Red = red;
            Green = green;
            Blue = blue;
        }

        public double Red { get; }
        public double Green { get; }
        public double Blue { get; }

        private bool CheckRange(double value)
        {
            return value >= 0.0 && value <= 1.0;
        }
    }
}