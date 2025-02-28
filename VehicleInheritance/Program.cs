using System.ComponentModel.DataAnnotations;

namespace VehicleInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Vehicle aWhip1 = new Vehicle();
            //Vehicle aWhip2 = new Vehicle("buick", "lacrosse", "2016");
            Car aCar = new Car("Cadillac", "ESV","2019","4");
            MotorCycle Bike = new MotorCycle("Trident", "Triumph", "2015", false);


            //Console.WriteLine(aWhip1.ToString());
            //Console.WriteLine(aWhip2.ToString());
            Console.WriteLine(aCar.ToString());
            Console.WriteLine(Bike.ToString());
        }
    }
}