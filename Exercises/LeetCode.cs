using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    public static class LeetCode
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var prev = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (prev.ContainsKey(nums[i]))
                    return new int[] { prev[nums[i]], i };

                if (!prev.ContainsKey(target - nums[i]))
                    prev.Add(target - nums[i], i);
            }

            return new int[2];
        }
    }
}
