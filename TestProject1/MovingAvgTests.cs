using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class MovingAvgTests
    {
        [TestMethod]
        public void differenceTest0()
        {
            var movingAvg = new MovingAvg();
            Assert.AreEqual(movingAvg.difference(2,new double[] { 3, 8, 9, 15 }),6.5);

        }
        [TestMethod]
        public void differenceTest1()
        {
            var movingAvg = new MovingAvg();
            Assert.AreEqual(movingAvg.difference(3,new double[] { 17, 6.2, 19, 3.4 }), 4.533333333333335);

        }
        public void differenceTest2()
        {
            var movingAvg = new MovingAvg();
            Assert.AreEqual(movingAvg.difference(3,new double[] { 6, 2.5, 3.5 }),0.0 );

        }
    }
}
