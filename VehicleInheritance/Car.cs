//written by Lucas Pautz
//2-25-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Car:Vehicle
    {
        private string numDoors = "0";

        public string NumDoors
        {
            get { return this.numDoors; }
            set { this.numDoors = value; }
        }

        public Car() : base() { }

        public Car(string aMake, string aModel, string aYear,string aNumDoors) : base(aMake, aModel, aYear)
        {

            this.numDoors = aNumDoors;
        }

        //public Car(string aMake, string aModel, string aYear, string aNumDoors) : base(aMake, aModel, aYear) { }
        

        public override string ToString()
        {
            string msg = "";
            msg += $"Make:{Make} Model:{Model} Year:{Year} Number of Doors:{NumDoors}";
            return msg;
        }


    }
}
