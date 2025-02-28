//written by Lucas Pautz
//2-26-2025
namespace ShapesAreas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Shape aShape = new Shape();
            Rectangle aRec = new Rectangle("blue");
            aRec.Width = 14.0;
            aRec.Length = 10;
            //i put length and width in wihtout a constructor to practice syntax
            Console.WriteLine(aRec.ToString());

            Circle aCircle = new Circle("Red",13.5);
            Console.WriteLine(aCircle.ToString());
            
            
        }
    }
}
