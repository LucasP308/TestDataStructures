//written by Lucas Pautz
//2-13-2025
namespace SimulasTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chest aChest = new Chest();
            int a = 1;
            do
            {

                Console.WriteLine(aChest.ToString());
                aChest.Choice = Console.ReadLine();
            } while (a == 1);

        }


            
       

        


        


            
        }
    }

