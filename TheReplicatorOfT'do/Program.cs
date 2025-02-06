namespace TheReplicatorOfT_do
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CopyArr aCopyArr = new CopyArr();

            Console.WriteLine("Enter 5 integers");
            for (int i = 0;i<5; i++)
            {
                aCopyArr.OriginalArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(aCopyArr.ToString());
        }
    }
}
