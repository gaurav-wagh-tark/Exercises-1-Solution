using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class PalindromeDecodingTests
    {
        [TestMethod]
        public void decodeTest0()
        {
            var palindrometest = new PalindromeDecoding();
            Assert.AreEqual(palindrometest.decode("ab",new int[] { 0},new int[]{ 2}),"abba");
        }[TestMethod]
        public void decodeTest1()
        {
            var palindrometest = new PalindromeDecoding();
            Assert.AreEqual(palindrometest.decode("Misip", new int[] { 2, 3, 1, 7 },new int[]{ 1, 1, 2, 2 }), "Mississippi");
        }[TestMethod]
        public void decodeTest2()
        {
            var palindrometest = new PalindromeDecoding();
            Assert.AreEqual(palindrometest.decode("XY", new int[] { 0, 0, 0, 0 }, new int[] { 2, 4, 8, 16 }), "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX");
        }[TestMethod]
        public void decodeTest3()
        {
            var palindrometest = new PalindromeDecoding();
            Assert.AreEqual(palindrometest.decode("TC206", new int[] { 1, 2, 5 },new int[]{ 1, 1, 1 }), "TCCC2006");
        }[TestMethod]
        public void decodeTest4()
        {
            var palindrometest = new PalindromeDecoding();
            Assert.AreEqual(palindrometest.decode("nodecoding", new int[] { },new int[]{ }), "nodecoding");
        }

    }
}
