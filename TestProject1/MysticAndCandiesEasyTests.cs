using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class MysticAndCandiesEasyTests
    {
        [TestMethod]
        public void minBoxesTest0()
        {
            var mtStic  = new MysticAndCandiesEasy();
            Assert.AreEqual(mtStic.minBoxes(10,10,new int[] {20}),1);
        }[TestMethod]
        public void minBoxesTest1()
        {
            var mtStic  = new MysticAndCandiesEasy();
            Assert.AreEqual(mtStic.minBoxes(10,7,new int[] {3,3,3,3,3}),4);
        }[TestMethod]
        public void minBoxesTest2()
        {
            var mtStic  = new MysticAndCandiesEasy();
            Assert.AreEqual(mtStic.minBoxes(100,63,new int[] { 12, 34, 23, 45, 34 }),3);
        }[TestMethod]
        public void minBoxesTest3()
        {
            var mtStic  = new MysticAndCandiesEasy();
            Assert.AreEqual(mtStic.minBoxes(19,12,new int[] {12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6,1, 7, 3, 4, 10, 3, 14}),22);
        }[TestMethod]
        public void minBoxesTest4()
        {
            var mtStic  = new MysticAndCandiesEasy();
            Assert.AreEqual(mtStic.minBoxes(326,109,new int[] {9, 13, 6, 6, 6, 16, 16, 16, 10, 16, 4, 3, 10, 8, 11, 17, 12, 5, 7,8, 7, 4, 15, 7, 14, 2, 2, 1, 17, 1, 7, 7, 12, 17, 2, 9, 7, 1, 8, 16,7, 4, 16, 2, 13, 3, 13, 1, 17, 6}),15);
        }
    }
}
