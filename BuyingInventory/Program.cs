//Written by Lucas Pautz
//2-5-2025
namespace BuyingInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inventory aInventory = new Inventory();
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1-Rope");
            Console.WriteLine("2-Torches");
            Console.WriteLine("3-Climbing Equipment");
            Console.WriteLine("4-Clean Water");
            Console.WriteLine("5-Machete");
            Console.WriteLine("6-Canoe");
            Console.WriteLine("7-Food Supplies");
            Console.Write("What number would you like to see the price of?: ");
            aInventory.InvNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aInventory.ToString());


        }
    }
}
