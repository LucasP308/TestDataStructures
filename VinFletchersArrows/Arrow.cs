//Written by Lucas Pautz
//2-13-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    public class Arrow
    {
        private float length = 0.0f;
        private string arrowtype = "n/a";
        private string fletchtype = "n/a";

        public float Length
        {
            get { return this.length; }
            set
            {
                if (value >= 60.0 && value <= 100.0)
                {
                    this.length = value;
                }
                else
                {
                    Console.WriteLine(NotInBound());
                    value = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

        public string ArrowType
        {
            get { return this.arrowtype; }
            set { this.arrowtype = value; }
        }
        public string FletchType
        {
            get { return this.fletchtype; }
            set { this.fletchtype = value; }
        }
        public double GetPrice()
        {
            FletchType = FletchType.Replace(" ", "").ToLower();
            ArrowType = ArrowType.ToLower();
            double price  = 0.0;
            price += 0.05 * Length;
            if(ArrowType == Convert.ToString(ArrowHead.steel))
            {
                price += 10;

            }
            else if(ArrowType == Convert.ToString(ArrowHead.wood))
            {

                price += 5;
            }
            else if (ArrowType == Convert.ToString(ArrowHead.obsidian))
            {
                price += 5;
            }

            if (FletchType == Convert.ToString(Fletchling.plastic))
            {
                price += 10;
            }
            else if (FletchType == Convert.ToString(Fletchling.turkeyfeather))
            {
                price += 5;
            }
            else if (FletchType == Convert.ToString(Fletchling.goosefeather))
            {
                price += 3;
            }


            return price;

            }

        public string NotInBound()
        {
            return "Please enter a proper length.";
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"The cost of your arrows cost {GetPrice():0.00} gold";
            return msg;
        }
    }


        enum ArrowHead { steel, wood, obsidian}
        enum Fletchling { plastic, turkeyfeather, goosefeather  }//10 gold, 5 gold, 3 gold
    }

