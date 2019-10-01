using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordplay;

namespace Wordplay.Test
{
    [TestClass]
    public class AnagramTest
    {
        Anagram anagram = new Anagram();
        [TestMethod]
        public void FindAnagrams_AlphabeticalInputOnly_TryAgain()
        {
            Assert.AreEqual("Alphabetical input only. Please try again.", anagram.FindAnagrams("10"));
        }
        [TestMethod]
        public void FindAnagrams_WordWithoutAnagrams_NoAnagrams()
        {
            Assert.AreEqual("No anagrams available.", anagram.FindAnagrams("truck"));
        }
        [TestMethod]
        public void FindAnagrams_SameLengthAnagram_Vile()
        {
            Assert.AreEqual("vile", anagram.FindAnagrams("evil"));
        }
    }
}