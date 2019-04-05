using System;

namespace Interview_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoNum Test
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = Arrays.TwoSum(nums, target);

            Console.Write("Twosum result is ");

            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();

            //MaxProfit Test
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            Console.WriteLine("The Maximum Profit is: " + Arrays.MaxProfit(prices));

            //ContainsDuplicate Test
            int[] numsDup = { 1, 2, 3, 1 };

            Console.Write("The array");

            if(Arrays.ContainsDuplicate(numsDup))
            {
                Console.Write(" is ");
            }
            else
            {
                Console.Write("isn't ");
            }

            Console.WriteLine("a duplicate.");
        }
    }
}
