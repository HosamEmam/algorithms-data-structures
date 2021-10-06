using NUnit.Framework;
using Solutions.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.SlidingWindow.Tests
{
    public class SeqenceCharactersTests
    {
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_Passinghello_Expects_hel()
        {
            var str = "hello";
            Assert.AreEqual("hel", SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_Passinghellothere_Expects_lother()
        {
            var str = "hellothere";
            Assert.AreEqual("lother", SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_Passinghellothers_Expects_lothers()
        {
            var str = "hellothers";
            Assert.AreEqual("lothers", SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_PassingUnique_Expects_Unique()
        {
            var str = "Unique";
            Assert.AreEqual("Unique", SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_Passingeeeeeee_Expects_e()
        {
            var str = "eeeeeee";
            Assert.AreEqual("e", SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
        [Test]
        public void GetLongestSequenceOfUniqueCharacters_When_PassingEmpty_Expects_null()
        {
            var str = "";
            Assert.IsEmpty(SeqenceCharacters.GetLongestSequenceOfUniqueCharacters(str));
        }
    }
}
