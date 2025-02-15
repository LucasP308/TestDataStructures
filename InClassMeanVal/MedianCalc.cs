//written by Lucas Pautz
//2-10-2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InClassMeanVal
{
    public class MedianCalc
    {

        public List<int> BubbleSort(List<int> Lyst, int LystLength)
        {
            int i = 0;
            int j = 0;
            int temp;
            bool swapped = false;
            for (i = 0; i <  LystLength; i++){
                swapped = false;
                for (j = 0; j < LystLength - i - 1; j++)
                {
                    if (Lyst[j] > Lyst[j + 1])
                    {
                        temp = Lyst[j];
                        Lyst[j] = Lyst[j + 1];
                        Lyst[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }

            return Lyst;
        }

        public int CalcMax(List<int>Lyst)
        {

            int max = Lyst[Lyst.Count - 1];
            return max;
        }
        public int CalcMin(List<int> Lyst)
        {

            int min = Lyst[0];
            return min;
        }
      
        public int CalcAvg(List<int> Lyst, int LystLength)
        {
            int sum = 0;

            for (int i = 0; i < LystLength ; i++)
            {
                sum += Lyst[i];
            }
            return sum / LystLength;
        }

        public int CalcMedian(List<int> Lyst, int LystLength)
        {
            int median = 0;
            if(LystLength % 2 == 0)
            {
               median =  (Lyst[LystLength/2] + Lyst[LystLength/2 - 1])/ 2;
               
            }
            else
            {
                median = Lyst[(LystLength/2)];
            }

            return median;
        }

        /*public override string ToString()
        {
            string msg += $"The maximum is: {CalcMax(Lyst,LystLength)}";
            

            
        }*/





    }
    }

