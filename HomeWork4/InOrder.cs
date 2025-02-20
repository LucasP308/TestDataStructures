//written by Lucas Pautz
//2-18-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class InOrder
    {
        public bool Order(string phrase)
        {
            bool msg = true;
            for (int i = 0; i < phrase.Length - 1; i++)
            {
                if ((int)phrase[i] <= (int)phrase[i + 1])
                {
                    
                }
                else
                {
                    msg = false;
                }
                
            }
            return msg;
        }

    }
}
