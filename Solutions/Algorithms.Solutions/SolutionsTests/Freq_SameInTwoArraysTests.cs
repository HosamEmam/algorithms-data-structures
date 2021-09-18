using NUnit.Framework;
using Algorithms.Solutions;
using Algorithms.Solutions.FrequencyCounter;

namespace Algorithms.Solutions.SolutionsTests
{
    /// <summary>
    /// Write a function called same, which accepts two arrays. 
    /// The function should return true if every value in the array has it's corresponding value squared in the second array. 
    /// The frequency of values must be the same.
    /// same([1,2,3], [4,1,9]) // true
    /// same([1,2,3], [1,9]) // false
    /// same([1,2,1], [4,4,1]) // false (must be same frequency)
    /// </summary>
    public class Freq_SameInTwoArraysTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]  
        public void Same_When_OneArrayHasSquareItemsForAnotherArray_Expect_True()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[]{ 4, 1, 9 };

            Assert.IsTrue(SameInArrays.Same(arr1, arr2));
        }
        [Test]  
        public void Same_When_AnotherOneArrayHasSquareItemsForAnotherArray_Expect_True()
        {
            var arr1 = new int[] { 1, 2, 3, 3 };
            var arr2 = new int[] { 9, 4, 1, 9 };

            Assert.IsTrue(SameInArrays.Same(arr1, arr2));
        }
        [Test] 
        public void Same_When_OneArrayLessThansAnotherArray_Expect_False()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[] { 1, 9 };

            Assert.IsFalse(SameInArrays.Same(arr1, arr2));
        }
        [Test] 
        public void Same_When_NotSameFrequency_Expect_False()
        {
            var arr1 = new int[] { 1, 2, 1 };
            var arr2 = new int[] { 4, 4, 1 };

            Assert.IsFalse(SameInArrays.Same(arr1, arr2));
        }

        [Test] 
        public void EnhancedSame_When_OneArrayHasSquareItemsForAnotherArray_Expect_True()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[] { 4, 1, 9 };

            Assert.IsTrue(SameInArrays.EnhancedSame(arr1, arr2));
        }

        [Test]  
        public void EnhancedSame_When_AnotherOneArrayHasSquareItemsForAnotherArray_Expect_True()
        {
            var arr1 = new int[] { 1, 2, 3, 3 };
            var arr2 = new int[] { 9, 4, 1, 9 };

            Assert.IsTrue(SameInArrays.EnhancedSame(arr1, arr2));
        }
        [Test]
        public void EnhancedSame_When_OneArrayLessThansAnotherArray_Expect_False()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[] { 1, 9 };

            Assert.IsFalse(SameInArrays.EnhancedSame(arr1, arr2));
        }
        [Test]
        public void EnhancedSame_When_NotSameFrequency_Expect_False()
        {
            var arr1 = new int[] { 1, 2, 1 };
            var arr2 = new int[] { 4, 4, 1 };

            Assert.IsFalse(SameInArrays.EnhancedSame(arr1, arr2));
        }
    }
}