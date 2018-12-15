using System;
using Cnx.Core.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cnx.UnitTests
{
    [TestClass]
    public class XM
    {
        [TestMethod]
        public void XM_OrFirstContent()
        {
            var full = "I have content!";
            var empty = "";

            Assert.AreEqual(full, full.OrFirstContent(empty), "Returns initial string if not empty");
            Assert.AreEqual(full, empty.OrFirstContent(full), "Returns first arg that is not empty (#0)");
            Assert.AreEqual(full, empty.OrFirstContent(empty, full), "Returns first arg that is not empty (#1)");
            Assert.AreEqual(full, empty.OrFirstContent(empty, empty, full), "Returns first arg that is not empty (#2)");
            Assert.AreEqual(empty, empty.OrFirstContent(empty, empty, empty), "Returns empty if no content");
        }

        [TestMethod]
        public void XM_Space()
        {
            Assert.AreEqual("1 2", "1".Space("2"), "Returns two items as space-separated list");
            Assert.AreEqual("1 2 3", "1".Space("2", "3"), "Returns three items as space-separated list");
            Assert.AreEqual("1 2   3", "1".Space("2", " ", "3"), "Treats embedded space as character");
            Assert.AreEqual("1", "1".Space(), "Can handle empty args");
        }
    }
}
