//written by Lucas Pautz
//2-10-2025
namespace InClassMeanVal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> Lyst = new List<int>();
            string temp = Console.ReadLine();
            string[] parts = temp.Split(' ');


            foreach (string part in parts)
            {
                Lyst.Add(Convert.ToInt32(part));
            }

            int LystLength = Lyst.Count;

            MedianCalc aCalc = new MedianCalc();
            aCalc.BubbleSort(Lyst, LystLength);



            Console.WriteLine($"The max is: {aCalc.CalcMax(Lyst)}");
            Console.WriteLine($"The min is: {aCalc.CalcMin(Lyst)}");
            Console.WriteLine($"The Avgerage is: {aCalc.CalcAvg(Lyst, LystLength)}");
            Console.WriteLine($"The median is : {aCalc.CalcMedian(Lyst, LystLength)}");
        }
        }
    }

