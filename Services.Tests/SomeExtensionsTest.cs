using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Rules;
using System.Collections.Generic;
using System.Diagnostics;

namespace Services.Tests
{
    [TestClass]
    public class SomeExtensionsTest
    {
        [TestMethod]
        public void TestPrimes()
        {
            TestPrimes(1, new int[] { 1 });
            TestPrimes(2, new int[] { 1, 2 });
            TestPrimes(3, new int[] { 1, 3 });
            TestPrimes(4, new int[] { 1, 2, 4 });
            TestPrimes(20, new int[] { 1, 2, 4, 5, 10, 20 });
        }

        public void TestPrimes(int input, int[] output)
        {
            //Debug.WriteLine("testing: " + input.ToString());
            CollectionAssert.AreEqual(output, input.Primes());
        }
    }
}
