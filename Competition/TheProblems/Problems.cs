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
            Assert.AreEqual(0, yourSolution.YearsAlive(DateTime.Now));
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(1, yourSolution.YearsAlive(DateTime.Now - TimeSpan.FromDays(365)));
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(10, yourSolution.YearsAlive(DateTime.Now - TimeSpan.FromDays(366*10)));
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            Assert.AreEqual(50, yourSolution.YearsAlive(DateTime.Now - TimeSpan.FromDays(366 * 50)));
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            Assert.AreEqual(100, yourSolution.YearsAlive(DateTime.Now - TimeSpan.FromDays(366 * 100)));
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