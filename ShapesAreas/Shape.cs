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
    public abstract class Shape
    {
        private string color = "n/a";


        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public abstract double GetArea();
        public Shape() : this("n/a") { }
        public Shape(string aColor)
        {
            this.color = aColor;
        }

        public override string ToString()
        {
            string msg = "";
            string shape = "n/a";
            msg += $"Shape: {shape}\nColor: {Color}\n";
            return msg;
        }


    }
}
