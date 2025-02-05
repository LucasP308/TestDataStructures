//Written By Lucas Pautz
//1-29-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleProblem
{
    public class TriangleCalc
    {   //class variables
        private double trianlgeBase = -1.0;
        private double triangleHeight = -1.0;

        //gets and sets
        public double TriangleBase
        {
            get; set;
        }
        public double TriangleHeight
        {
            get; set;
        }

        //methods

        public double CalcArea()
        {
            double triangleArea = (TriangleHeight * TriangleBase) * 0.5;
            return triangleArea;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"The area of the triangle is {CalcArea()} units";
            return msg;

        }

    }
}
