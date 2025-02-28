//written by lucas pautz
// 2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Specialist:Employee
    {
        private string specialty = "n/a";


        public string Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Specialist() : this("n/a", "n/a","n/a") { }
        public Specialist(string aName, string aSalary, string aSpecialty) : base(aName, aSalary)
        {
            this.specialty = aSpecialty;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"Specialist Name: {Name} \nSalary: {Salary} \nSpecialty: {Specialty}\n";
            return msg;
        }
    }
}
