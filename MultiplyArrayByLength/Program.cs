//Lucas Pautz
//2-12-2025
namespace MultiplyArrayByLength
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MultiplyArr aArr = new MultiplyArr();

            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(aArr.ToString(array));
        }
    }
}
