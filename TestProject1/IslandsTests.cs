using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class IslandsTests
    {
        [TestMethod]
        public void beachLengthTest0()
        {
            var iseland = new Islands();
            Assert.AreEqual(iseland.beachLength(new string[]{".#...#.."}),4);
        }[TestMethod]
        public void beachLengthTest1()
        {
            var iseland = new Islands();
            Assert.AreEqual(iseland.beachLength(new string[]{"..#.##",".##.#.","#.#..."}),19);
       }
    
        [TestMethod]
        public void beachLengthTest2()
        {
            var iseland = new Islands();
            Assert.AreEqual(iseland.beachLength(new string[]{"#...#.....","##..#...#."}), 15);
        }
        [TestMethod]
        public void beachLengthTest3()
        {
            var iseland = new Islands();
            Assert.AreEqual(iseland.beachLength(new string[]{"....#.",".#....","..#..#","####.."}), 24);
        }
    }
}
