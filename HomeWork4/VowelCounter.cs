//Written by Lucas Pautz
//2-18-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class VowelCounter
    {
        public string VowelCount(string word, int num)
        {
            string vowel = "";
            int count = 0;
            word = word.ToLower();
            for( int i = 0 ; i < word.Length; i++)
            {
                if (count < num)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    {
                        vowel += word[i];
                        count++;
                    }
                }
            }
            if(count < num)
            {
                vowel = "invalid";
            }
            return vowel;
        }
    }
}
