using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_1_Solution;

namespace TestProject1
{
    [TestClass]
    public class MailboxTests
    {
        [TestMethod]
        public void impossibleTest0()
        {
            var mailBox = new Mailbox();
            Assert.AreEqual(mailBox.impossible("AAAAAAABBCCCCCDDDEEE123456789", new String[] { "123C", "123A", "123 ADA" }), 0);
        }[TestMethod]
        public void impossibleTest1()
        {
            var mailBox = new Mailbox();
            Assert.AreEqual(mailBox.impossible("ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890", new String[] { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" }), 3);
        }[TestMethod]
        public void impossibleTest2()
        {
            var mailBox = new Mailbox();
            Assert.AreEqual(mailBox.impossible("ABCDAAST", new String[] { "111 A ST", "A BAD ST", "B BAD ST" }), 2);
        }
    }
}
