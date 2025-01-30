//Written by Lucas Pautz
//1-27-2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public class QuizCalculatorClass
    {
        private double quiz1 = -999.99;
        private double quiz2 = -999.99;
        private double quiz3 = -999.99;
        private double quiz4 = -999.99;
        //private double total = -999.99;
       // private double avg = -999.9;
        //private string letterGrade = "n/a";


    
        //gets and sets
        public double Quiz1
        {
            get { return this.quiz1; }
            set {
                if ((value > 100) || (value < 0)) {
                    this.quiz1 = -999.99;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }

        public double Quiz2
        {
            get { return this.quiz2; }
            set {
                if ((value > 100) || (value < 0))
                {
                    this.quiz2 = -999.99;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }

        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if ((value > 100) || (value < 0))
                {
                    this.quiz3 = -999.99;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }

        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if ((value > 100) || (value < 0))
                {
                    this.quiz4 = -999.99;
                }
                else
                {
                    this.quiz4 = value;
                }
            }
        }

        //methods

        public double CalcTotal()
        {
            double aTotal = 0.0;
            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;
            return aTotal;
        }

        public double CalcAVG()
        {
            double anAverage = 0.0;
            anAverage = CalcTotal()/ 4;
            return anAverage;
        }

        public string CalcLetterGrade()
        {
            string letterGrade = "n/a";
            double avg = CalcAVG();//4 is a magic number should have this variable input by the user
            if( avg < 60.0)
            {
                letterGrade = "F";
            }
            
            else if (avg < 70.0)
            {
                letterGrade = "D";
            }
            else if(avg< 80.0)
            {
                letterGrade = "C";
            }
            else if ( avg < 90.0)
            {
                letterGrade = "B";
            }
            else
            {
                letterGrade = "A";
            }
            return letterGrade; 
        }




    }
}
// for an empty list [] works as well as new List regarding the document sent by joe after mav pass on 1-27-2025