using System;
using Xunit;

namespace UnitTests
{
    public class LeetCode
    {
        [Fact]
        public void TwoSumBasic()
        {
            var ans = Exercises.LeetCode.TwoSum(new int[] { 1, 2, 3, 4 }, 5);

            Assert.Equal(new int[] { 1, 2 }, ans);
        }

        [Fact]
        public void TwoSumRepeating()
        {
            var ans = Exercises.LeetCode.TwoSum(new int[] { 1, 2, 2, 3, 4 }, 5);

            Assert.Equal(new int[] { 1, 3 }, ans);
        }
    }
}
