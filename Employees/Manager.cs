//written by lucas pautz
// 2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Manager:Employee
    {
        private int empsManaged = 0;


        public int EmpsManaged
        {
            get { return this.empsManaged; }
            set { this.empsManaged = value; }
        }

        public Manager() : this("n/a", "n/a",0) { }
        public Manager(string aName, string aSalary,int aEmpsManaged):base(aName, aSalary)
        {
            this.empsManaged = aEmpsManaged;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"Manager Name: {Name} \nSalary: {Salary} \nEmployees Managed: {EmpsManaged}\n";
            return msg;
        }
    }
}
