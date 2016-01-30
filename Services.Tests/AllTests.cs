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
        public void TestFib()
        {
            //TestHello(2, new int[] { 1 });
            //TestHello(3, new int[] { 2 });
            TestHello(4, new int[] { 3 });
            TestHello(new int[] { 4, 3 },  new int[] { 3, 2 });
        }

        public void TestHello(int input, int[] output)
        {
            FibController gc = new FibController();
            CollectionAssert.AreEqual(gc.Post(new int[] { input }), output);
        }

        public void TestHello(int [] input, int[] output)
        {
            FibController gc = new FibController();
            CollectionAssert.AreEqual(gc.Post(input) , output);
        }
        //[TestMethod]
        //public void TestHello()
        //{
        //    TestHello(2, new string[] { "Hello World", "Hello World" });
        //    TestHello(4, new string[] { "Hello World", "Hello World", "Hello World", "Hello World" });
        //}

        //public void TestHello(int input, string[] output)
        //{
        //    HelloController gc = new HelloController();
        //    CollectionAssert.AreEqual(gc.Post(new int[]{input}), output);
        //}
    }
}
