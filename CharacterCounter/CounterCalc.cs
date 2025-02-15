//written by Lucas Pautz
//2-12-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter
{
    public class CounterCalc
    {
        public int CountChar(string word, char Letter)
        {

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == Letter)
                {
                    count++;
                }
                

            }
            return count;
        }
    }
}
