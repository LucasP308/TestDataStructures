//written by Lucas Pautz
//2-26-2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ShapesAreas
{
    public class Rectangle:Shape
    {
        private double length = 0.0;
        private double width = 0.0;


        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public override double GetArea()
        {
            return Length * Width;
        }
        public Rectangle() : base("n/a") { }
        public Rectangle(string aColor):base(aColor) 
        {
           
        }

        public override string ToString()
        {
            string msg = "";
            string shape = "Rectangle";
            msg += $"Shape: {shape}\nColor: {Color}\nArea: {GetArea()}\n";
            return msg;

        }

    }
}
