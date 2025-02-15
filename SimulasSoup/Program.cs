//written by Lucas Puatz
//2-14-2025

namespace SimulasSoup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Soup aSoup = new Soup();
            Console.WriteLine("Choose a Soup type 0-soup, 1-stew,2-gumbo");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a main ingrediant  0-mushroom, 1-chicken,2-carrot, 3-potatoe");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a seasoning 0-spicy, 1-salty,2-sweet");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aSoup.ToString(a, b, c));

        }
    }
}
