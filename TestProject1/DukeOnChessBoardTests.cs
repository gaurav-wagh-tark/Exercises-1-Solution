using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class DukeOnChessBoardTests
    {
        [TestMethod]
        public void checkpathTest0()
        {
            var dukeOnChessBosrdTest = new DukeOnChessBoard();

            var Result = dukeOnChessBosrdTest.dukePath(3, "b2");

            Assert.IsTrue(Result == "b2-c2-c3-b3-a3-a2-a1-b1-c1");
        }
        [TestMethod]
        public void checkpathTest1()
        {
            var dukeOnChessBosrdTest = new DukeOnChessBoard();

            var Result = dukeOnChessBosrdTest.dukePath(4, "d4");

            Assert.IsTrue(Result == "d4-d3-d2-d1-c1-c2-c3...b3-b2-b1-a1-a2-a3-a4");
        }
        [TestMethod]
        public void checkpathTest2()
        {
            var dukeOnChessBosrdTest = new DukeOnChessBoard();

            var Result = dukeOnChessBosrdTest.dukePath(3, "a2");

            Assert.IsTrue(Result == "a2-b2-c2-c3-b3-a3");
        }

        [TestMethod]
        public void checkpathTest3()
        {
            var dukeOnChessBosrdTest = new DukeOnChessBoard();

            var Result = dukeOnChessBosrdTest.dukePath(4, "d3");

            Assert.IsTrue(Result == "d3-d4-c4-c3-c2-d2-d1...b2-b3-b4-a4-a3-a2-a1");
        }
        [TestMethod]
        public void checkpathTest4()
        {
            var dukeOnChessBosrdTest = new DukeOnChessBoard();

            var Result = dukeOnChessBosrdTest.dukePath(8, "a8");

            Assert.IsTrue(Result == "a8-b8-c8-d8-e8-f8-g8...a1-a2-a3-a4-a5-a6-a7");
        }

    }
}
