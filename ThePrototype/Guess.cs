//Written by Lucas Pautz
//2-6-2025
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrototype
{
    public class Guess
    {//class variables
        private int playerNum = -1;
        private int guesserNum = -1;



        //gets and sets
        public int PlayerNum
        {
            get { return this.playerNum; }
            set { this.playerNum = value; }
        }
        public int GuesserNum
        {
            get { return this.guesserNum; }
            set { this.guesserNum = value; }
        }


        //methods

        public string GuessCheck()
        {
            if(GuesserNum < PlayerNum){
                return "Higher";
                }
            else if (GuesserNum > PlayerNum)
            {
                return "Lower";
            }
            else
            {
                return "You guessed it!";
            }
        }

        public override string ToString()
        {
            string msg = "";

            msg += GuessCheck();
            return msg;

            
        }
    }
}
