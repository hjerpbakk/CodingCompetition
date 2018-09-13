using System.Collections.Generic;
using Runner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSolution;

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
            Assert.AreEqual(false, yourSolution.IsLeapYear(2015));
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(true, yourSolution.IsLeapYear(1996));
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(false, yourSolution.IsLeapYear(2100));
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            Assert.AreEqual(true, yourSolution.IsLeapYear(2000));
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            Assert.AreEqual(false, yourSolution.IsLeapYear(1997));
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