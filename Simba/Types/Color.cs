﻿namespace Simba.Types
{
    public class Color
    {
        public double Red { get; }
        public double Green { get; }
        public double Blue { get; }

        public Color(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}