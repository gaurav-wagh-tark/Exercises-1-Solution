using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class MaximumBalancesTests
    {
        [TestMethod]
        public void solveTests0()
        {
            var maximum = new MaximumBalances();
            Assert.AreEqual(maximum.solve("(((("),0);
        }[TestMethod]
        public void solveTests1()
        {
            var maximum = new MaximumBalances();
            Assert.AreEqual(maximum.solve("(())"),3);
        }[TestMethod]
        public void solveTests2()
        {
            var maximum = new MaximumBalances();
            Assert.AreEqual(maximum.solve(")))())"),1);
        }[TestMethod]
        public void solveTests3()
        {
            var maximum = new MaximumBalances();
            Assert.AreEqual(maximum.solve("))()()))(()"),10);
        }
    }
}
