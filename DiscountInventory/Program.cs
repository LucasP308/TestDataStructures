//Written by Lucas Pautz
//2-6-2025
namespace DiscountInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Discount aDiscount = new Discount();
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1-Rope");
            Console.WriteLine("2-Torches");
            Console.WriteLine("3-Climbing Equipment");
            Console.WriteLine("4-Clean Water");
            Console.WriteLine("5-Machete");
            Console.WriteLine("6-Canoe");
            Console.WriteLine("7-Food Supplies");
            Console.Write("What number would you like to see the price of?: ");
            aDiscount.InvNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            aDiscount.Name = Console.ReadLine();
            Console.WriteLine(aDiscount.ToString());
        }
    }
}
