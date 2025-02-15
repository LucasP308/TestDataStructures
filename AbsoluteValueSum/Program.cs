//written by Lucas Pautz
//2-12-2025
namespace AbsoluteValueSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalcSum aCalc = new CalcSum();
            int[] array = [-4,5,64,-25];




            Console.WriteLine(aCalc.ToString(array));
        }
    }
}
