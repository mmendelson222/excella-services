using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Rules;
using System.Collections.Generic;
using System.Diagnostics;
using Services.Controllers;

namespace Services.Tests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void TestHello()
        {
            TestHello(2, new string[] { "Hello World", "Hello World" });
            TestHello(4, new string[] { "Hello World", "Hello World", "Hello World", "Hello World" });
        }

        public void TestHello(int input, string[] output)
        {
            HelloController gc = new HelloController();
            CollectionAssert.AreEqual(gc.Post(new int[]{input}), output);
        }
    }
}
