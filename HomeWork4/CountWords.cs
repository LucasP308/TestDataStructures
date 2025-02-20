//written by Lucas Pautz
//2-18-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class CountWords
    {

        public int WordCount(string aWord)
        {
            
            string []word= aWord.Split(' ');
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                count++;
            }
            return count;

        }

        public string ToString(string aWord)
        
        {
            string msg = "";
            msg += $"{WordCount(aWord)}";
            return msg;
        }

    }
}
