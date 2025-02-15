//written by Lucas Pautz
//2-12-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GetTheLargerStringNumber
{
    public  class SmallerNum
    {
        private string firstNum = "n/a";
        private string secNum = "n/a";



        public string FirstNum
        {
            get { return this.firstNum; }
            set { this.firstNum = value; }
        }

        public string SecondNum
        {
            get { return this.secNum; }
            set { this.secNum = value; }
        }

        public string CompareNum()
        {
            int num1 = Convert.ToInt32(FirstNum);
            int num2 = Convert.ToInt32(SecondNum);
            if (num2 < num1)
            {
                return SecondNum;
            }
            else
            {
                return FirstNum;
            }
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"The smaller number is {CompareNum()}";
            return msg;

        }
    }
}
