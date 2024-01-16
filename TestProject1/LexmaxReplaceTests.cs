using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class LexmaxReplaceTests
    {
        [TestMethod]
        public void getTest0()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("abb", "c"), "cbb");
        }
        [TestMethod]
        public void getTest1()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("z", "f"), "z");
        }
        [TestMethod]
        public void getTest2()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("fedcba", "ee"), "feeeba");
        }
        [TestMethod]
        public void getTest3()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("top", "coder"), "trp");
        }
        [TestMethod]
        public void getTest4()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk"), "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr");
        }
    }
}
