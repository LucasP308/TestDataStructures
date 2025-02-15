//written by Lucas Pautz
//2-14-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SimulasSoup
{
    public class Soup
    {
        Soups food;
        Ingrediant main;
        Seasoning taste;

       


        public  string ToString(int a, int b, int c)
        {
            string msg = "";
            Soups food = (Soups)a;
            Ingrediant main = (Ingrediant)b;
            Seasoning taste = (Seasoning)c;
            var FoodType = (Soups: food, Ingrediant: main, Seasoning: taste);
            msg += $"{FoodType.Seasoning} {FoodType.Ingrediant} {FoodType.Soups}";
            return msg;
        }





    }
        enum Soups { soup, stew, gumbo}

        enum Ingrediant { mushroom, chicken , carrot, potatoe }

        enum Seasoning { spicy, salty, sweet }

        

    }

