using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public class Cargo
    {
        public double Length { set; get; }
        public double Width { set; get; }
        public double Height { set; get; }
        public double Weight { set; get; }
        public double Way { set; get; }
        public transType type;
        public Cargo() { }
        public Cargo(double length, double width, double height, double weight, double way)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            Way = way;
        }
        public double getVolume()
        {
            return Length * Width * Height;
        }
    }
}
