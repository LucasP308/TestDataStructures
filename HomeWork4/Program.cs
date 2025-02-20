//written by Lucas Pautz
//2-18-2025
using System;
using System.Diagnostics;

namespace HomeWork4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number \n0- word counter\n1-Swap First Letter\n2-Is your string in order" +
                    "\n3-Vowel Counter\n4- Letter Changer\n5- to quit");
            int problem = Convert.ToInt32(Console.ReadLine());


            do
            {
                switch (problem)
                {
                    case 0:
                        CountWords aCount = new CountWords();
                        Console.WriteLine("Enter a String:");
                        string word = Console.ReadLine();
                        Console.WriteLine(aCount.ToString(word));
                        break;
                    case 1:
                        SwapFirst_Last aSwap = new SwapFirst_Last();
                        Console.WriteLine("Enter a string:");
                        string word2 = Console.ReadLine();
                        Console.WriteLine(aSwap.Swap(word2));
                        break;
                    case 2:

                        InOrder aOrder = new InOrder();
                        Console.WriteLine("Enter a string:");
                        string word3 = Console.ReadLine();
                        Console.WriteLine(aOrder.Order(word3));
                        //ps this uses ASCII comparisions so putting 10 is read as 1 and 0 not ten
                        break;
                    case 3:

                        VowelCounter aVowelCounter = new VowelCounter();
                        Console.WriteLine("Enter a String:");
                        string word4 = Console.ReadLine();
                        Console.WriteLine("Enter a number of vowels to return");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(aVowelCounter.VowelCount(word4, num));
                        break;
                    case 4:

                        ChangeLetter aChange = new ChangeLetter();
                        Console.WriteLine("Enter a string");
                        string word5 = Console.ReadLine();
                        Console.WriteLine(aChange.LetterChanger(word5));
                        break;
                    case 5:
                        break;

                    
                }
                Console.WriteLine();
                Console.WriteLine("enter a number \n0- word counter\n1-Swap First Letter\n2-Is your string in order" +
                    "\n3-Vowel Counter\n4- Letter Changer\n5- to quit");
                problem = Convert.ToInt32(Console.ReadLine());
            } while (problem != 5);





        }
    }
}
