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
            Assert.AreEqual(7, yourSolution.CountLowerCasetLetters("FirstTest"));
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(0, yourSolution.CountLowerCasetLetters("DIPS"));
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual(2, yourSolution.CountLowerCasetLetters("1337 og 1984"));
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            Assert.AreEqual(12, yourSolution.CountLowerCasetLetters("Chicken dinner"));
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            Assert.AreEqual(3, yourSolution.CountLowerCasetLetters("!#¤%&/()=abc{[]"));
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