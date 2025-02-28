//written by Lucas Pautz
//2-25-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class Vehicle
    {
        private string make = "n/a";
        private string model = "n/a";
        private string year = "n/a";

        //gets and sets
        public string Make
        {
            set { this.make = value; }
            get { return this.make; }

        }
        public string Model
        {
            set { this.model = value; }
            get { return this.model; }

        }
        public string Year
        {
            set { this.year = value; }
            get { return this.year; }

        }

        //contructors

        public Vehicle(string aMake, string aModel, string aYear)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
        }
        public Vehicle():this("not provided","not provided", "not provided"){}


        public override string ToString()
        {
            string msg = "";
            msg += $"Model:{Model} Make:{Make} Year:{Year}";

            return msg;
        }

    }
}
