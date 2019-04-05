using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep
{
    class Arrays
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            //local variables
            Hashtable indexOfNums = new Hashtable();
            int remainder;       

            for (int i = 0; i < nums.Length; i++)
            {
                //if the remainder is already in the hashtable, return the indices and the index of the remainder value.
                remainder = target - nums[i];
                if (indexOfNums.ContainsKey(remainder))
                {
                    if(nums[i] + remainder == target)
                    {
                        return new int[] { (int) indexOfNums[remainder], i};
                    }             
                }
                //Otherwise, adds it into the hash table
                else if(!indexOfNums.ContainsKey(nums[i]))
                {
                    indexOfNums.Add(nums[i], i);
                }
            }

            //Returns an empty array otherwise.
            return new int[] { 0, 0 };
        }

        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int maxProfit = 0;
            int minPrice = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                //if minPrice's value is initialized or less than the value shown, set it to be minPrice
                if (i == 0 || minPrice > prices[i])
                {
                    minPrice = prices[i];
                }

                profit = prices[i] - minPrice;

                //If the calculated profit is higher than the current max Profit, set it to be max Profit
                if (profit > 0 && profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }

            return maxProfit;
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            //local variables
            Hashtable dupCount = new Hashtable();    

            for (int i = 0; i < nums.Length; i++)
            {
                //if the number is already in the hashtable, return true.
                if (dupCount.ContainsKey(nums[i]))
                {
                    return true;         
                }
                //Otherwise, adds it into the hash table
                else
                {
                    dupCount.Add(nums[i], 1);
                }
            }

            return false;
        }
    }
}
