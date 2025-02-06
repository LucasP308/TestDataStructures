//Written by Lucas Pautz
//2-6-2025
using System.Runtime.InteropServices;

namespace TheMagicCanon
{
    public class Program

    {

        public string BlastType(int fire, int electric,int i)
        {
            if(i%fire == 0 && i % electric == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return "Fire and Eletric";
            }
            else if(i%fire == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Fire";
            }
            else if(i%electric == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Electric";
            }
            Console.ForegroundColor = ConsoleColor.White;
            return "Normal";
        }
        public static void Main(string[] args)
        {
            Program aBlastType = new Program();
            int fire = 3;
            int electric = 5;
            int i = 0;
            //int j = 0;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Blast {i} is {aBlastType.BlastType(fire,electric, i)}");

            }
        }
    }
}
