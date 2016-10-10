namespace TestDIPS.Competition
{
    using DIPS.Competition;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Runner;

    /// <summary>
    /// The tests.
    /// 
    /// Do not change this class.
    /// </summary>
    [TestClass]
    public class TheTests : TestBase
    {
        private FibonacciSequence fibonacciSequence;

        [TestInitialize]
        public void SetUp()
        {
            fibonacciSequence = new FibonacciSequence();
        }

        [TestMethod]
        public void FirstTest()
        {
            var result = fibonacciSequence.GetFibonacciNumber(1);

            Assert.AreEqual(1, result);
            Succeeded(1);
        }

        [TestMethod]
        public void SecondTest()
        {
            var result = fibonacciSequence.GetFibonacciNumber(2);

            Assert.AreEqual(1, result);
            Succeeded(2);
        }

        [TestMethod]
        public void ThirdTest()
        {
            var result = fibonacciSequence.GetFibonacciNumber(3);

            Assert.AreEqual(2, result);
            Succeeded(3);
        }

        [TestMethod]
        public void FourthTest()
        {
            var result = fibonacciSequence.GetFibonacciNumber(4);

            Assert.AreEqual(3, result);
            Succeeded(4);
        }

        [TestMethod]
        public void FifthTest()
        {
            var result = fibonacciSequence.GetFibonacciNumber(20);

            Assert.AreEqual(6765, result);
            Succeeded(5);
        }

#region CompetitionLogic
        [ClassCleanup]
        public static void ClassCleanup()
        {
            TestsEnded();
        }
#endregion
    }
}
