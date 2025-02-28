//written by lucas pautz
// 2-26-2025
namespace Employees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee aEmployee = new Employee("John Deer","$65,000");
            Manager aManger = new Manager("Mike Sherm","$92,000",48);
            Specialist aSpecialist = new Specialist("Lucas Pautz", "$42", "Breathing heavy");
            Console.WriteLine(aEmployee);
            Console.WriteLine(aManger);
            Console.WriteLine(aSpecialist);
           
        }
    }
}
