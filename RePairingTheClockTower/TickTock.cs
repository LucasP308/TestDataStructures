//Written By Lucas Pautz
//2-1-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace RePairingTheClockTower
{
    public class TickTock
    {
        private int num = 0;
    

    //gets and sets
    public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
        //methods

        public bool NumIsOdd()
        {
            int number = Num;
            bool isOdd = false;
            if ((number % 2) > 0)
            {
                isOdd = true;
            }
            else
            {
                isOdd = false;
            }
            return isOdd;
        }
        public override string ToString()
        {
            string msg = "";
            if (NumIsOdd() == false)
            {
                msg += "Tick\n";
            }
            else
            {
                msg += "Tock\n";
            }
            return msg;
        }
    }
}
