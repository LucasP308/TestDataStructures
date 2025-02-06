//Written by Lucas Pautz
//2-6-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountInventory
{
    public class Discount
    {
        //class variables
        private string name = "n/a";
        private int invNum = -1;



        //gets and sets
        public int InvNum
        {
            get; set;
        }

        public string Name
        {
            get;set;
        }


        //methods

        public string getPrice()
        {
            double gold = 1.0;
            if(Name == "Lucas Pautz")
            {
                gold = 0.5;
            }
            int num = InvNum;
            switch (InvNum)
            {
                case 1:

                    return $"Rope costs {gold*10} gold.";
                case 2:
                    return $"Torches cost {gold*15} gold.";
                case 3:
                    return $"CLimbing Equipment costs {gold * 25} gold.";
                case 4:
                    return $"Clean Water cost {gold * 1} gold.";
                case 5:
                    return $"A Machete costs {gold * 20} gold.";
                case 6:
                    return $"A Canoe cost {gold * 200} gold.";
                case 7:
                    return $"Food Supplies costs {gold * 1} gold.";
                default:
                    return "Enter a number from 1-7";
            }
        }


        public override string ToString()
        {
            string msg = getPrice();
            return msg;

        }

    }
}
