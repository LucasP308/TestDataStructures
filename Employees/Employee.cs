//written by lucas pautz
// 2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        private string name = "n/a";
        private string salary = "n/a";


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }


        public Employee() : this("n/a", "n/a") { }
        public Employee(string aName, string aSalary)
        {
            this.name = aName;
            this.salary = aSalary;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"Employee Name: {Name} \nSalary: {Salary}\n";
            return msg;
        }
    }
}
