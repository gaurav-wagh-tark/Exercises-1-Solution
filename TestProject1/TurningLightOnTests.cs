using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class TurningLightOnTests
    {
        [TestMethod]
        public void minFlipsTest1()
        {
            var fiTurningLightOnleName = new TurningLightOn();

            var result = fiTurningLightOnleName.minFlips(new string[] { "0001111", "0001111", "1111111" });

            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void minFlipsTest2()
        {
            var fiTurningLightOnleName = new TurningLightOn();

            var result = fiTurningLightOnleName.minFlips(new string[] { "1111111", "1111111", "1111111" });

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void minFlipsTest3()
        {
            var fiTurningLightOnleName = new TurningLightOn();

            var result = fiTurningLightOnleName.minFlips(new string[] { "01001" });

            Assert.AreEqual(result, 3);
        }


        [TestMethod]
        public void minFlipsTest4()
        {
            var fiTurningLightOnleName = new TurningLightOn();

            var result = fiTurningLightOnleName.minFlips(new string[] { "0101", "1010", "0101", "1010" });

            Assert.AreEqual(result, 7);
        }
    }
}
