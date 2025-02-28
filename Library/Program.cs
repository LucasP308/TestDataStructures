//written by Lucas Pautz
//2-26-2025
namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EBook aEbook = new EBook("Some name", "Some guy", "2022", "12");
            Console.WriteLine(aEbook.ToString());

            PrintedBook aBook = new PrintedBook("another name", "another guy", "2022", "300");
            Console.WriteLine(aBook.ToString());
            //Console.WriteLine("Hello, World!");
        }
    }
}
