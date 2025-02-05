//Written by Lucas Pautz
//1-29-2025


namespace TheTriangleProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The Triangle Farmer
            TriangleCalc aTriangleCalc = new TriangleCalc();

            Console.Write("Input the base of the triangle: ");
            aTriangleCalc.TriangleBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the height of the triangle: ");
            aTriangleCalc.TriangleHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(aTriangleCalc.ToString());
        }
    }
}
