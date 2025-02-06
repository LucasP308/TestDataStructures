//written by Lucas Pautz
//2-5-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuyingInventory
{
    public  class Inventory
    {//class variables
        private int invNum = -1;
        


        //gets and sets
        public int InvNum
        {
            get;set;
        }
        

        //methods

        public string getPrice()
        {
            int num = InvNum;
            switch (InvNum)
            {
                case 1:
                    return "Rope costs 10 gold.";
                case 2:
                    return "Torches cost 15 gold.";
                case 3:
                    return "CLimbing Equipment costs 25 gold.";
                case 4:
                    return "Clean Water cost 1 gold.";
                case 5:
                    return "A Machete costs 20 gold.";
                case 6:
                    return "A Canoe cost 200 gold.";
                case 7:
                    return "Food Supplies costs 1 gold.";
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
