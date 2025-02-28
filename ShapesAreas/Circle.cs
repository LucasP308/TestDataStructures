//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreas
{
    public class Circle:Shape
    {
        private double radius = 0.0;


        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }


        public Circle() : base("n/a") { }
        public Circle(string aColor,double aRadius) : base(aColor)
        {
            this.radius = aRadius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            string msg = "";
            string shape = "Circle";
            msg += $"Shape: {shape}\nColor: {Color}\nColorArea: {GetArea():0.00}\n";
            return msg;

        }
    }
}
