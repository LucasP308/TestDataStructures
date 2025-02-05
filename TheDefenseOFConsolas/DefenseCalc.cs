//Written by Luacs Pautz
//2-1-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDefenseOFConsolas
{
    //Class Variables
    public class DefenseCalc
    {
        private int row = 0;
        private int col = 0;

        //gets and sets
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Col
        {
            get { return this.col; }
            set { this.col = value; }

        }
        // methods
        public int CalcDefenseRow1()
        {
            
            int position = Row -1;
            return position;

        }
        public int CalcDefenseRow2()
        {
            int position = Row + 1;
            return position;
        }
        public int CalcDefenseCol3()
        {
           int position = Col - 1;
           return position;
        }
        public int CalcDefenseCol4()
        {
            int position = Col + 1;
            return position;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Deploy to: \n";
            msg += $"({Row},{CalcDefenseCol3()})\n";
            msg += $"({CalcDefenseRow1()},{Col})\n";
            msg += $"({Row},{CalcDefenseCol4()})\n";
            msg += $"({CalcDefenseRow2()},{Col})";
            return msg;
        }
        

    }
}
