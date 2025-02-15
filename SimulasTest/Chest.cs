//written by Lucas Pautz
//2-14-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasTest
{
    public class Chest
    {
        private string choice = "open";
        ChestType ch = ChestType.open;
        

        public string Choice
        {
            get { return choice; }
            set { this.choice = value; }
        }

        public string ChestChoice()
        {
            Choice = Choice.ToLower();
            if (Choice == "close" && ch == ChestType.open)
            {
                ch = ChestType.closed;
                
            }
            else if (Choice == "open" && ch == ChestType.closed)
            {
                ch = ChestType.open;
            }
            else if (Choice == "lock" && ch == ChestType.closed)
            {
                ch = ChestType.locked;
            }
            else if (Choice == "unlock" && ch == ChestType.locked)
            {
                ch = ChestType.closed;
            }
            return ch.ToString();
            

        }



        public override string ToString()
        {
            string msg = "";
            
            msg += $"The chest is {ChestChoice()} what do you want to do?: ";
            return msg;


        }
        enum ChestType { open, closed, locked };
    }
}
