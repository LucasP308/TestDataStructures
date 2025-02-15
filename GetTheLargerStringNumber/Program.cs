//written by Lucas Pautz
//2-12-2025
namespace GetTheLargerStringNumber
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            SmallerNum aNumComp  = new SmallerNum();
            aNumComp.FirstNum = Console.ReadLine();
            aNumComp.SecondNum = Console.ReadLine();
            Console.WriteLine(aNumComp.ToString());



        }
    }
}
