//Written by Lucas Pautz
//2-6-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheReplicatorOfT_do
{
    public class CopyArr
    {// class variables
        private int[] originalArr = new int [5];
        

        //methods
        public int[] OriginalArr
        {
            get {  return this.originalArr; }
            set { this.originalArr = value; }
        }

        public int[] CopyArray()
        {
            int[] copy = new int[5];
            for (int i = 0; i < OriginalArr.Length; i++)
            {
                copy[i] = OriginalArr[i];
            }
            return copy;
                
        }

        public override string ToString()
        {
            string msg = "";
            int[] arr = CopyArray();
            msg += "Orignal Array: ";
            foreach (int i in OriginalArr)
            {
                msg += i + " ";
            }
            msg += "\n";
            msg += "Copied Array: ";
            foreach (int i in arr)
            {
                msg += i + " ";
            }
            return msg;
        }

    }
}
