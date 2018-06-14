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
            var distinctConcat = yourSolution.Median("1, 2, 3, 4, 5");

            Assert.AreEqual(5, distinctConcat);
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            var distinctConcat = yourSolution.Median("45, 90, 1, 1235, 17, 3, 9");

            Assert.AreEqual(17, distinctConcat);
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            var distinctConcat = yourSolution.Median("32, 54, 12, 64, 42");

            Assert.AreEqual(42, distinctConcat);
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            var distinctConcat = yourSolution.Median("5, 4, 3, 2, 1");

            Assert.AreEqual(3, distinctConcat);
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            var distinctConcat = yourSolution.Median("90, 72, 17, 15, 19");

            Assert.AreEqual(19, distinctConcat);
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