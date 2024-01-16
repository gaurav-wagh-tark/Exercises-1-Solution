using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class HuffmanDecodingTests
    {
        [TestMethod] 
        public void DecoderTest0()
        {
            var huffmanDecodingTest = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecodingTest.Decoder("101101", new String[] { "00","10","01","11"}),"BDC");
        }[TestMethod] 
        public void DecoderTest1()
        {
            var huffmanDecodingTest = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecodingTest.Decoder("10111010", new String[] { "0", "111", "10" }), "CBAC");
        }[TestMethod] 
        public void DecoderTest2()
        {
            var huffmanDecodingTest = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecodingTest.Decoder("0001001100100111001", new String[] { "1", "0" }), "BBBABBAABBABBAAABBA");
        }[TestMethod] 
        public void DecoderTest3()
        {
            var huffmanDecodingTest = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecodingTest.Decoder("111011011000100110", new String[] { "010", "00", "0110", "0111", "11", "100", "101" }), "EGGFAC");
        }[TestMethod] 
        public void DecoderTest4()
        {
            var huffmanDecodingTest = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecodingTest.Decoder("001101100101100110111101011001011001010", new String[] { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" }), "DBHABBACAIAIC");
        }
    }
}
