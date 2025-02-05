//Written by Lucas Pautz
//1-29-2025
namespace TheSistersAndDuckbear
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            SisterAndDuckBear aSisterBear = new SisterAndDuckBear();
            Console.Write("Input the number of chocolate eggs to be dispersed: ");
            aSisterBear.ChocEggs = int.Parse(Console.ReadLine());
            Console.WriteLine(aSisterBear.ToString());
            //  some scenarios where the duckbear gets more choclate eggs is where there are 1,2,3,6,7, or 11 eggs
        }
    }
}
