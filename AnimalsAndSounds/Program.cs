//written by Lucas Pautz
//2-26-2025
namespace AnimalsAndSounds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog aDog = new Dog("Dog");
            Cat aCat = new Cat("Cat");
            Console.WriteLine(aDog.ToString());
            Console.WriteLine(aCat.ToString());
        }
    }
}
