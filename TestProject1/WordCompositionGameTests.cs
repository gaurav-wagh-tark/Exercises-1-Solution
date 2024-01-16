using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class WordCompositionGameTests
    {
        [TestMethod]
        public void scoreTests0()
        {
            var wordComposite = new WordCompositionGame();
            Assert.AreEqual(wordComposite.score(new String[] {"cat", "dog", "pig", "mouse"},new String[] { "cat", "pig" }, new String[] { "dog", "cat" }), "8/3/3");
        }
        [TestMethod]
        public void scoreTests1()
        {
            var wordComposite = new WordCompositionGame();
            Assert.AreEqual(wordComposite.score(new String[] { "mouse" }, new String[] { "cat", "pig" }, new String[] { "dog", "cat" }), "3/5/5");
        }[TestMethod]
        public void scoreTests2()
        {
            var wordComposite = new WordCompositionGame();
            Assert.AreEqual(wordComposite.score(new String[] { "dog", "mouse"},new String[] { "dog", "pig" }, new String[] { "dog", "cat" }), "4/4/4");
        }[TestMethod]
        public void scoreTests3()
        {
            var wordComposite = new WordCompositionGame();
            Assert.AreEqual(wordComposite.score(new String[] { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" }, new String[] { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" }, new String[] {"dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda"}), "14/14/21");
        }
    }
}
