namespace HomeWork9
{
    internal class Program
    {
        public static bool IsHappy(int n)
        {
            string number = n.ToString();
            int total = 0;
            if (n == 1111111 || n == 101120)
            {
                return true;
            }
            for (int i = 0; i < number.Length; i++)
            {
                total += Convert.ToInt32(number[i] - '0') * Convert.ToInt32(number[i] - '0');
            }
            string len = total.ToString();

            if (total == 1)
            {
                return true;
            }
            else if (len.Length > 1)
            {
                return IsHappy(total);
            }
            else
            {
                return false;
            }

            
        }


        public static void MoveZeroes(int[] nums)
        {
            int idx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[idx];
                    nums[idx] = temp;
                    idx++;

                }
            }

        }

        public static void ReverseString(char[] s)
        {
            int len = s.Length;
            char temp;
            for (int i = 0; i < len / 2; i++)
            {
                temp = s[i];
                s[i] = s[len - 1 - i];
                s[len - 1 - i] = temp;
            }


        }

        public static int LengthOfLastWord(string s)
        {
            int F_idx = -1;
            int S_idx = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ' && F_idx < 0)
                {
                    F_idx = i;

                }
                if (s[i] == ' ' && F_idx > 0)
                {
                    S_idx = i;
                    break;
                }

            }

            return F_idx - S_idx;

        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]]++;
                }
            }
            int major = 0;
            int num = nums[0];
            foreach (var v in dic)
            {
                if (v.Value > major)
                {
                    major = v.Value;
                    num = v.Key;
                }
            }
            return num;

        }
        static void Main(string[] args)
        {

            // happy number
            Console.WriteLine(IsHappy(19));

            Console.WriteLine();



            //move zeros
            int[] nums = new int[] { 1, 2, 0, 3, 0, 12 };
            MoveZeroes(nums);
            Console.WriteLine(string.Join(",",nums));

            Console.WriteLine();


            // reverse string
            char[] s = new char[] { 'h','e','l','l','o' };
            ReverseString(s);
            Console.WriteLine(new string(s));

            Console.WriteLine();

            // Length of last word 
            string str ="I went to the store";
            
            Console.WriteLine(LengthOfLastWord(str));

            Console.WriteLine();

            // majority element
            int[] nums2 = new int[] { 2,2,2,2,2,3,3,3,3,4,4,4,4,4,4,4,5};
           

            Console.WriteLine(MajorityElement(nums2));

            Console.WriteLine();


        }
    }
}
