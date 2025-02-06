//Written by Lucas Pautz
//2-4-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    public class EnemyLocationCalc
    {
        //class variables
        private int x = 0;
        private int y = 0;





        //gets and sets
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        //methods

        public string EnemyLocation()
        {


            if (X < 0)
            {
                if (Y > 0)
                {
                    return "The Enemy is NorthWest!";
                }
                else if (Y == 0)
                {
                    return "The Enemy is West!";
                }
                else
                {
                    return "The Enemy is SouthWest!";
                }
            }
            else if (X == 0)
            {
                if (Y > 0)
                {
                    return "The Enemy is North!";
                }
                else if (Y == 0)
                {
                    return "The Enemy is here!";
                }
                else
                {
                    return "The Enemy is South!";
                }
            }
            else
            {
                if (Y > 0)
                {
                    return "The Enemy is NorthEast!";
                }
                else if (Y == 0)
                {
                    return "The Enemy is East!";
                }
                else
                {
                    return "The Enemy is SouthEast!";
                }
            }

        }


        public override string ToString()
        {
            string msg = EnemyLocation();
            return msg;
        }
    }
}
