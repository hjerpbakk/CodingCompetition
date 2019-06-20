using System.Collections.Generic;
using Runner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSolution;
using System;

namespace TheProblems
{
    /// <summary>
    /// The tests.
    /// 
    /// Do not change this class.
    /// </summary>
    [TestClass]
    public class Problems
    {
        private Solution yourSolution;

        [TestInitialize]
        public void SetUp()
        {
            yourSolution = new Solution();
        }

        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(true, yourSolution.IsPalindrome("A"));
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(false, yourSolution.IsPalindrome("DIPS"));
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(true, yourSolution.IsPalindrome("1331"));
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            Assert.AreEqual(false, yourSolution.IsPalindrome("NDC"));
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            Assert.AreEqual(true, yourSolution.IsPalindrome("racecar"));
            Succeeded(5);
        }

        #region Helpers

        private static int[] results;

        [ClassInitialize]
        public static void ClassSetup(TestContext notUsed)
        {
            results = new int[5];
        }

        [ClassCleanup]
        public static void ClassTearDown()
        {
            new Communicator().Write(string.Join<int>(",", (IEnumerable<int>)results));
        }

        protected void Succeeded(int n)
        {
            //int[] results = results;
            int num1 = n - 1;
            n = num1;
            int index = num1;
            int num2 = 1;
            results[index] = num2;
        }

        #endregion
    }
}