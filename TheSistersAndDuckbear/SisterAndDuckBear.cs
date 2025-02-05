//Written by Lucas Pautz
//1-29-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSistersAndDuckbear
{
    public class SisterAndDuckBear
    {
        //class variables
        private int chocEggs = -1;


        //gets and sets
        public int ChocEggs
        {
            get; set;
        }


        //methods

        public int EggsPerSister()
        {
            int eggsPerSister = ChocEggs / 4;
            return eggsPerSister;
        }
        public int EggsForDuckBear()
        {
            int eggsForDuckBear = ChocEggs % 4;
            return eggsForDuckBear;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Each sister gets {EggsPerSister()} cocolate eggs \nThe DuckBear gets {EggsForDuckBear()} chocolate eggs";
            return msg;
        }
    }
}
