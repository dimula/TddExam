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
        public void IsAutomorphic_AutomorphicNumbersTest()
        {
            var testArr = new int[] { 0, 1, 5, 6, 76, 376 };
            foreach(var num in testArr)
            {
                var res = _automorphicTester.IsAutomorphic(num);
                Assert.IsTrue(res);
            }
        }

        [TestMethod()]
        public void IsAutomorphic_NonAutomorphicNumbersTest()
        {
            var testArr = new int[] { 2,3,777,895,120};
            foreach (var num in testArr)
            {
                var res = _automorphicTester.IsAutomorphic(num);
                Assert.IsFalse(res);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsAutomorphic_NegativeInputThrowsArgumentOutOfRangeExceptionTest()
        {
            _automorphicTester.IsAutomorphic(-5);
        }

        [TestMethod()]
        [ExpectedException(typeof(OverflowException))]
        public void IsAutomorphic_OverflowExceptionTest()
        {
            _automorphicTester.IsAutomorphic(int.MaxValue);
        }
    }
}