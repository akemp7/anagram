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
    }
}