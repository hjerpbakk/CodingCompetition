using System.Collections.Generic;
using Runner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSolution;

namespace TheProblems {
    /// <summary>
    /// The tests.
    /// 
    /// Do not change this class.
    /// </summary>
    [TestClass]
    public class Problems {
        private Solution yourSolution;

        [TestInitialize]
        public void SetUp() {
            yourSolution = new Solution();
        }

        [TestMethod]
        public void DIPSFact_1() {
            var dipsFact = "DIPS AS har 6 kontorer: Trondheim, Bodø, Tromsø, Oslo, Bergen og Stockholm.";
            var theNumber = yourSolution.ExtractNumer(dipsFact);

            Assert.AreEqual(6, theNumber);
            Succeeded(1);
        }

        [TestMethod]
        public void DIPSFact_2() {
            var dipsFact = "DIPS AS har hatt bursdag og i år fylte vi 30 :)";
            var theNumber = yourSolution.ExtractNumer(dipsFact);

            Assert.AreEqual(20, theNumber);
            Succeeded(2);
        }

        [TestMethod]
        public void DIPSFact_3() {
            var dipsFact = "DIPS AS lager pasientdatasystemer for 85 % av det norske markedet.";
            var theNumber = yourSolution.ExtractNumer(dipsFact);

            Assert.AreEqual(85, theNumber);
            Succeeded(3);
        }

        [TestMethod]
        public void DIPSFact_4() {
            var dipsFact = "DIPS blir brukt av over 80000 brukere hver dag.";
            var theNumber = yourSolution.ExtractNumer(dipsFact);

            Assert.AreEqual(80000, theNumber);
            Succeeded(4);
        }

        [TestMethod]
        public void DIPSFact_5() {
            var dipsFact = "DIPS AS har 280 fantastiske medarbeidere som venter spent på å treffe akkurat deg.";
            var theNumber = yourSolution.ExtractNumer(dipsFact);

            Assert.AreEqual(280, theNumber);
            Succeeded(5);
        }

        #region Helpers

        private static int[] results;

        [ClassInitialize]
        public static void ClassSetup(TestContext notUsed) {
            results = new int[5];
        }

        [ClassCleanup]
        public static void ClassTearDown() {
            new Communicator().Write(string.Join<int>(",", (IEnumerable<int>) results));
        }

        protected void Succeeded(int n) {
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