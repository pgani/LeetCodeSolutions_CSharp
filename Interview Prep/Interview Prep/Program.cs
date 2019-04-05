using System;

namespace Interview_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = Arrays.TwoSum(nums, target);

            Console.Write("Result is ");

            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
