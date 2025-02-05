//Written by Lucas Pautz
//2-1-2025
namespace TheDefenseOFConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Defense of Consolas");

            DefenseCalc aDefenseCalc = new DefenseCalc();

            Console.WriteLine("Input numbers between 1-8 inclusive.");

            Console.Write("Target Row: ");
            aDefenseCalc.Row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column: ");
            aDefenseCalc.Col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aDefenseCalc.ToString());
            Console.Beep();


        }
    }
}
