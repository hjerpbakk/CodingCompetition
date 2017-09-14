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
            var distinctConcat = yourSolution.DistinctConcat("DIPS AS is a great place to work");

            Assert.AreEqual("DIPS AS is a great place to work", distinctConcat);
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            var distinctConcat = yourSolution.DistinctConcat(
                "DIPS AS is a great place to work. \n" +
                "We have open positions");

            Assert.AreEqual("DIPS AS is a great place to work. We have open positions", distinctConcat);
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            var distinctConcat = yourSolution.DistinctConcat(
                "DIPS AS is a great place to work. \n" +
                "We have open positions \n" +
                "in Trondheim, Bodø, Oslo and Tromsø");

            Assert.AreEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", distinctConcat);
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            var distinctConcat = yourSolution.DistinctConcat(
                "DIPS AS is a great place to work. \n" +
                "We have open positions \n" +
                "in Trondheim, Bodø, Oslo and Tromsø\n" +
                "in Trondheim, Bodø, Oslo and Tromsø");

            Assert.AreEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", distinctConcat);
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            var distinctConcat = yourSolution.DistinctConcat(
                "DIPS AS is a great place to work. \n" +
                "DIPS AS is a great place to work. \n" +
                "We have open positions \n" +
                "in Trondheim, Bodø, Oslo and Tromsø. \n" +
                "in Trondheim, Bodø, Oslo and Tromsø. \n" +
                "Come join us!");

            Assert.AreEqual("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø. Come join us!", distinctConcat);
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