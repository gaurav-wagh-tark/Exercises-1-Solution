using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class LargestSubsequenceTests
    {
        [TestMethod]
        public void getLargestTest0()
        {
            var largest = new LargestSubsequence();
            Assert.AreEqual(largest.getLargest("test"), "tt");
        }[TestMethod]
        public void getLargestTest1()
        {
            var largest = new LargestSubsequence();
            Assert.AreEqual(largest.getLargest("a"), "a");
        }[TestMethod]
        public void getLargestTest2()
        {
            var largest = new LargestSubsequence();
            Assert.AreEqual(largest.getLargest("example"), "xple");
        }[TestMethod]
        public void getLargestTest()
        {
            var largest = new LargestSubsequence();
            Assert.AreEqual(largest.getLargest("aquickbrownfoxjumpsoverthelazydog"), "zyog");
        }
    }
}
