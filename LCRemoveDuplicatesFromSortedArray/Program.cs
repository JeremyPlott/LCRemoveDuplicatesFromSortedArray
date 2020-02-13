using System;
using System.Collections.Generic;
using System.Linq;

namespace LCRemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };

            RemoveDuplicates(nums);

            foreach (var num in nums) { Console.WriteLine(num); }

            int[] RemoveDuplicates(int[] nums)
            {
                var uniqueNums = 0;

                for (int num = 0; num < nums.Length; num++)
                {
                    while (num < nums.Length - 1 && nums[num] == nums[num + 1]) num++;                    

                    nums[uniqueNums] = nums[num];

                    uniqueNums++;
                }

                return nums;
            }
        }
    }
}
