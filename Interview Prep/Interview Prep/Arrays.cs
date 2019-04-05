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
                //if the remainder is already in the hashmap, return the indices and the index of the remainder value.
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
    }
}
