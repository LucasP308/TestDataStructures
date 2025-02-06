// Written by Lucas Pautz
//2-4-2025
namespace WatchTower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EnemyLocationCalc aEnemy = new EnemyLocationCalc();

            Console.Write("Enter an x value:");
            aEnemy.X= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a y value:");
            aEnemy.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aEnemy.ToString());
        }
    }
}
