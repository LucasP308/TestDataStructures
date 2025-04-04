using System;
using System.Runtime.InteropServices.Marshalling;

namespace HomeWoek6
{
    public class Program
    {
        //merge two sorted arrays
        public static void Merge(int[] nums1, int m, int[] nums2, int n){

        for (int i = 0; i < nums2.Length; i++)
        {
            nums1[m + i] = nums2[i];
        }

        bool swap = false;
        int temp = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            swap = false;
            for (int a = 0; a < nums1.Length - i - 1; a++)
            {
                if (nums1[a] > nums1[a + 1])
                {
                    temp = nums1[a];
                    nums1[a] = nums1[a + 1];
                    nums1[a + 1] = temp;
                    swap = true;

                }


            }
            if (swap == false)
            {
                break;
            }
        }
    }

    //sort by parity
    public static int[] SortArrayByParity(int[] nums)
    {
        int length = nums.Length;
        int[] arr = new int[length];
        int j = 0;
        int a = length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                arr[j] = nums[i];
                j++;
            }
            else
            {
                arr[a] = nums[i];
                a--;
            }
        }
        return arr;
    }

    //remove element in array
    public static int RemoveElement(int[] nums, int val)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
                
        }
        return j;

    }

    //two sum
    public static int[] TwoSum(int[] nums, int target)
    {
        int i, j;
        for (i = 0; i < nums.Length - 1; i++)
        {
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { 0, 0 };

    }

    //needle in haystack

    public static int StrStr(string haystack, string needle)
    {
            int num = -1;
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                for (int a = 0; a < needle.Length; a++)
                {
                    if (haystack[i + a] != needle[a])
                    {
                        break;
                    }
                    if (haystack[i + a] == needle[a] && a == needle.Length - 1)
                    {
                        num = i;
                        return num;
                    }

                }
            }
        }
            return num;

    }

    
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 5, 6, 8, 1, 7 };
            int[] ParityArr = SortArrayByParity(arr);
            foreach(int item in ParityArr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();


            string needle = "bro";
            string haystack = "Heartbroken";
            int num = StrStr(haystack, needle);
            Console.WriteLine(num); //this wont print but my solution works on leetcode


            int[] TwoSumArr = new int[] { 2, 4, 5, 6, 8, 1, 7 };
            int target = 13;

            foreach(int item in (TwoSum(TwoSumArr, target))){
                Console.Write(item+" ");

            }
            Console.WriteLine();


            int[] RemoveElementArr = new int[] { 2, 4, 5, 7, 8, 8, 8, 12 };
            int val = 8;
            int num2 = RemoveElement(RemoveElementArr, val);
            Console.WriteLine(num2);//returns how many "vals" are removed



        }
    }
}
