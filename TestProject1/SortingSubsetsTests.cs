using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class SortingSubsetsTests
    {
        [TestMethod]
        public void getMinimalSizeTest0()
        {
            var sortingSubsets = new SortingSubsets();
            Assert.AreEqual(sortingSubsets.getMinimalSize(new int[] { 3, 2, 1 }),2);
        }

        [TestMethod]
        public void getMinimalSizeTest1()
        {
            var sortingSubsets = new SortingSubsets();
            Assert.AreEqual(sortingSubsets.getMinimalSize(new int[] { 1, 2, 3, 4}), 0);
        }

        [TestMethod]
        public void getMinimalSizeTest2()
        {
            var sortingSubsets = new SortingSubsets();
            Assert.AreEqual(sortingSubsets.getMinimalSize(new int[] { 4,4,4,3,3,3}), 6);
        }

        [TestMethod]
        public void getMinimalSizeTest3()
        {
            var sortingSubsets = new SortingSubsets();
            Assert.AreEqual(sortingSubsets.getMinimalSize(new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 }), 7);
        }
    }
}
