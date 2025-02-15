using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written by Lucas Pautz
//2-12-2025

namespace AbsoluteValueSum
{
    public class CalcSum
    {
        public int Calc( int []arr)
        {
            int total = 0;
            for (int i = 0; i< arr.Length; i++)
            {
                total += Math.Abs(arr[i]);
            }
            return total;
        }

        public string ToString(int[] arr)
        {
            
            string msg = "";
            msg += ($"The absolute value sum of the array is: {Calc( arr)}");
            return msg;
        }
    }
}
