//Written By Lucas Pautz
//2-1-2025
namespace RePairingTheClockTower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TickTock aticktock = new TickTock();

            Console.WriteLine("Enter any Integer");
          
            
                
            aticktock.Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aticktock.ToString());
                
            
            
        }
    }
}
