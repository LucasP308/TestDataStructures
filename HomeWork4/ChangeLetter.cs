//written by lucas pautz
//2-20-2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class ChangeLetter
    {
        public string LetterChanger(string word)
        {
            string newWord = "";
            for(int i = 0; i < word.Length; i++)
            {
                newWord += (char)(word[i]+1);
               
            }
            return newWord;
            
        }

    }
}
