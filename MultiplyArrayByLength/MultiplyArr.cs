//wirtten by Lucas Pautz
//2-12-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArrayByLength
{
    public class MultiplyArr
    {
        public int [] CalcArr(int[] arr)
        {
            int[] multArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                multArr[i] = arr[i] * arr.Length;
            }

            return multArr;

        }
    

    public string ToString(int[] array)
        {
            int [] multArr = CalcArr(array);
            string msg = "";
            msg += "The new Array is[";
            for (int i = 0; i < multArr.Length; i++)
            {
                if (i < multArr.Length - 1)
                {
                    msg += $"{multArr[i]},";
                }
                else
                {
                    msg += $"{multArr[i]}]";
                }
            }
            return msg;
            }
        }
}
