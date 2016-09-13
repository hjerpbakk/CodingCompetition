using System.Collections.Generic;
using Runner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDC2015.Competition;

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
        private ItDagene2016 yourSolution;

        [TestMethod]
        public void SetUp()
        {
            yourSolution = new ItDagene2016();
        }

        [TestMethod]
        public void FirstTest()
        {
            var nthPrime = yourSolution.NthPrime(26);
            
            Assert.AreEqual(101, nthPrime);
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            var nthPrime = yourSolution.NthPrime(46);

            Assert.AreEqual(199, nthPrime);
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            var nthPrime = yourSolution.NthPrime(148);

            Assert.AreEqual(857, nthPrime);
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            var nthPrime = yourSolution.NthPrime(1000);

            Assert.AreEqual(7919, nthPrime);
            Succeeded(4);
        }

        #region Helpers
        private int[] results;

        [TestInitialize]
        public void ClassSetup()
        {
            results = new int[4];
        }

        [TestCleanup]
        public void ClassTearDown()
        {
            new Communicator().Write(string.Join<int>(",", (IEnumerable<int>)this.results));
        }

        protected void Succeeded(int n)
        {
            int[] results = this.results;
            int num1 = n - 1;
            n = num1;
            int index = num1;
            int num2 = 1;
            results[index] = num2;
        }
        #endregion
    }
}
