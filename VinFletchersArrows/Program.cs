//Written by Lucas Pautz
//2-13-2025
namespace VinFletchersArrows
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Arrow aCalc = new Arrow();
            Console.WriteLine("Enter the length of your arrow between 60-100cm: ");
            aCalc.Length = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the type of arrow head: Steel, Wood , or Obsidian");
            aCalc.ArrowType = Console.ReadLine();

            Console.WriteLine("Enter the type of fletchling you'd like: Plastic, turkey feather, or goose feathers");
            aCalc.FletchType = Console.ReadLine();
            Console.WriteLine(aCalc.ToString());
        }
            


        }
    }

