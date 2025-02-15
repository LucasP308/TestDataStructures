//Written by Lucas Pautz
//2-23-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingTheManticore
{
    public class Manticore
    {
        private int manticoreHealth = 10;
        private int cityHealth = 15;
        private int targetRange = 0;
        private int shotRange = 0;
        private int round = 1;


        public int ManticoreHealth
        {
            
            get { return this.manticoreHealth; }
            set { this.manticoreHealth = value; }
        }

        public int CityHealth
        {
            get { return this.cityHealth; }
            set {  this.cityHealth = value; }
            }
        
        public int TargetRange
        {
            get { return this.targetRange;}
            set { this.targetRange = value; }

        }

        public int ShotRange
        {
            get { return this.shotRange; }
            set { this.shotRange = value; }
        }

        public int Round
        {
            get { return this.round; }
            set { this.round = value; }
        }

        public int Damage()
        {
            int damage = 1;
            if (Round % 3 == 0)
            { 
            damage = 3;
            
        }
            else if(Round % 5 == 0){
                damage = 5;
               
            }
            else if(Round % 15 == 0)
            {
                damage = 15;
            }
            else
            {
                damage = 1;
            }
            return damage;
       
        }
        public int CalcCityHealth()
        {
            return CityHealth - (Round - 1);
        }
        public int CalcManticoreHealth()
        {
            if(ShotRange == TargetRange)
            {
                 ManticoreHealth -= Damage();
            }
            return ManticoreHealth;
        }


        public override string ToString()
        {
            string msg = "";
            msg += $"STATUS: Round:{Round} City: {CityHealth}/15 Manticore: {CalcManticoreHealth()}/10\n";
            msg += $"The cannon is expected to do {Damage()} damage this round.\n";
            msg += $"Enter desired cannon range: ";
            //ShotRange = Convert.ToInt32(Console.ReadLine());
            

            return msg;

        }

    }
}
