//Written by Lucas Pautz
//2-18-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class SwapFirst_Last
    {
        public string Swap(string phrase) 
        {
            string word;
            if (phrase.Length < 2)
            {
                phrase = "Incompatible";

            }
            else if (phrase[0] == phrase[phrase.Length - 1])
            {
                phrase = "Two's a pair";
            }
            else
            {
                
                phrase = phrase+ phrase[0];
                phrase = phrase.Remove(0, 1);
            }
            return phrase;
        }
    }
}
