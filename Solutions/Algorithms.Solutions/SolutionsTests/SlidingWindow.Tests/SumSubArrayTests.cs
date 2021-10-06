using NUnit.Framework;
using Solutions.SlidingWindow;

namespace UnitTests.SlidingWindow.Tests
{
    public class SumSubArrayTests
    {
        [Test]
        public void GetMaxSum_When_ArrayIsExist_Expects_23()
        {
            var arr = new int[] { 1, 5, 2, 6, 8, 9, 1, 5, 8 };
            var num = 3;
            Assert.AreEqual(23, SumSubArray.GetMaxSum(arr, num));
        }
        [Test]
        public void GetMaxSum_When_ArrayIsExist_Expects_Max()
        {
            var arr = new int[] { 1, 5, 2, 6, 8, 9, 1, 5, 8 };
            var num = 2;
            Assert.AreEqual(17, SumSubArray.GetMaxSum(arr, num));
        }
        [Test]
        public void GetMaxSum_When_ArrayIsEmpty_Expects_Null()
        {
            var arr = new int[] { };
            var num = 2;
            Assert.IsNull(SumSubArray.GetMaxSum(arr, num));
        }
    }
}
