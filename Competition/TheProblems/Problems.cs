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
            var median = yourSolution.ClosestToZero("0, 1, -1, 3");

            Assert.AreEqual(0, median);
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            var median = yourSolution.ClosestToZero("45, 90, 1, 1235, 17, 3, 9");

            Assert.AreEqual(1, median);
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            var median = yourSolution.ClosestToZero("32, 54, 12, 2, -2, 64, 42");

            Assert.AreEqual(-2, median);
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            var median = yourSolution.ClosestToZero("5, 4, 3, 2, 1");

            Assert.AreEqual(1, median);
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            var median = yourSolution.ClosestToZero("90, 72, 17, 15, 19");

            Assert.AreEqual(15, median);
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