using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace TddExam.Tests
{
    [TestClass()]
    public class AutomorphicTesterTests
    {
        AutomorphicTester _automorphicTester;

        [TestInitialize]
        public void TestInitialize()
        {
            _automorphicTester = new AutomorphicTester();
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            _automorphicTester = null;
        }

        [TestMethod()]
        public void IsAutomorphicTester_AutomorphicNumbersTest()
        {
            var testArr = new int[] { 0, 1, 5, 6, 76, 376 };
            foreach(var num in testArr)
            {
                var res = _automorphicTester.IsAutomorphicTester(num);
                Assert.IsTrue(res);
            }
        }

        [TestMethod()]
        public void IsAutomorphicTester_NonAutomorphicNumbersTest()
        {
            var testArr = new int[] { 2,3,777,895,120};
            foreach (var num in testArr)
            {
                var res = _automorphicTester.IsAutomorphicTester(num);
                Assert.IsFalse(res);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAutomorphicTester_NegativeInputThrowsArgumentOutOfRangeExceptionTest()
        {
            _automorphicTester.IsAutomorphicTester(-5);
        }

        [TestMethod()]
        [ExpectedException(typeof(OverflowException))]
        public void IsAutomorphicTester_OverflowExceptionTest()
        {
            _automorphicTester.IsAutomorphicTester(int.MaxValue);
        }
    }
}