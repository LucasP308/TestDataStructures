//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    public class MotorCycle:Vehicle
    {
        private bool sideCar = false;

        public bool SideCar
        {
            get { return this.sideCar; }
            set { this.sideCar = value; }
        }


        public MotorCycle(string aMake,string aModel, string aYear, bool hasSideCar):base(aMake,aModel, aYear)
        {
            this.SideCar = hasSideCar;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Make:{Make} Model:{Model} Year:{Year} Side Car:{SideCar}";
            return msg;
        }

    }
}
