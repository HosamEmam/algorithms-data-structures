using NUnit.Framework;
using Algorithms.Solutions.FrequencyCounter;

namespace Algorithms.Solutions.UnitTests.FrequencyCounter.Tests
{
    /// <summary>
    /// Given two strings, write a function to determine if the second string is an anagram of the first. 
    /// An anagram is a word, phrase, or name formed by rearranging the letters of another, such as cinema, formed from iceman.
    ///validAnagram('', '') // true
    ///validAnagram('aaz', 'zza') // false
    ///validAnagram('anagram', 'nagaram') // true
    ///validAnagram("rat","car") // false) // false
    ///validAnagram('awesome', 'awesom') // false
    ///validAnagram('qwerty', 'qeywrt') // true
    ///validAnagram('texttwisttime', 'timetwisttext') // true
    /// </summary>
    public class Freq_AnagramTests
    {
        [Test]
        public void CheckAnagram_When_TwoStringsIsEmpty_Expects_True()
        {
            var str1 = "";
            var str2 = "";
            Assert.IsTrue(AnagramCheck.IsAnagram(str1, str2));
        }
        [Test]
        public void CheckAnagram_When_TwoStringsIsNotSameLength_Expects_False()
        {
            var str1 = "abc";
            var str2 = "aaaa";
            Assert.IsFalse(AnagramCheck.IsAnagram(str1, str2));
        }

        [Test]
        public void CheckAnagram_When_TwoStringsAreAnagrm_Expects_True()
        {
            var str1 = "abc";
            var str2 = "cba";
            Assert.IsTrue(AnagramCheck.IsAnagram(str1, str2));
        }

        [Test]
        public void CheckAnagram_When_TwoStringsNotAnagrm_Expects_False()
        {
            var str1 = "awesome";
            var str2 = "awesoms";
            Assert.IsFalse(AnagramCheck.IsAnagram(str1, str2));
        }
        [Test]
        public void CheckAnagram_When_TwoStringsAreAnagrmWithOneStringHasUpperCases_Expects_True()
        {
            var str1 = "texttwisttime";
            var str2 = "Timetwisttext";
            Assert.IsTrue(AnagramCheck.IsAnagram(str1, str2));
        }
    }
}