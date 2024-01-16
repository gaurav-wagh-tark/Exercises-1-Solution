using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class PrintSchedulerTests
    {
        [TestMethod]
        public void getOutputTest0()
        {
            var print = new PrintScheduler();
            Assert.AreEqual(print.getOutput(new String[] { "AB", "CD" }, new String[] { "0 1", "1 1", "0 1", "1 2" }), "ACBDC");
        }[TestMethod]
        public void getOutputTest1()
        {
            var print = new PrintScheduler();
            Assert.AreEqual(print.getOutput(new String[] { "ABCDE" }, new String[] { "0 20", "0 21" }), "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA");
        }[TestMethod]
        public void getOutputTest2()
        {
            var print = new PrintScheduler();
            Assert.AreEqual(print.getOutput(new String[] { "A", "B" }, new String[] { "1 10", "0 1", "1 10", "0 2" }), "BBBBBBBBBBABBBBBBBBBBAA");
        }[TestMethod]
        public void getOutputTest3()
        {
            var print = new PrintScheduler();
            Assert.AreEqual(print.getOutput(new String[] { "A" }, new String[] { "0 1"}), "A");
        }
    }
}
