//Written by Lucas Pautz
//2-12-2025

namespace CharacterCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CounterCalc aCalc = new CounterCalc();
            Console.WriteLine("Enter a letter to check for: ");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a sentnce or phrase:");
            string phrase = Convert.ToString(Console.ReadLine());
            phrase = phrase.ToLower();
            letter = Char.ToLower(letter);

            Console.WriteLine($"There are {aCalc.CountChar(phrase, letter)} {letter}'s in your phrase");
        }
    }
}
