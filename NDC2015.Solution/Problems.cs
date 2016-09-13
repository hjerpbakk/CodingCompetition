using NUnit.Framework;
using Runner;

namespace NDC2015.Solution
{
    /// <summary>
    /// The tests.
    /// 
    /// Do not change this class.
    /// </summary>
    [TestFixture]
    public class Problems : TestBase
    {
        private Competition.ItDagene2016 yourSolution;

        [SetUp]
        public void SetUp()
        {
            yourSolution = new Competition.ItDagene2016();
        }

        [Test]
        public void FirstTest()
        {
            var nthPrime = yourSolution.NthPrime(26);

            Assert.AreEqual(101, nthPrime);
            Succeeded(1);
        }

        [Test]
        public void SecondTest()
        {
            var nthPrime = yourSolution.NthPrime(46);

            Assert.AreEqual(199, nthPrime);
            Succeeded(2);
        }

        [Test]
        public void ThirdTest()
        {
            var nthPrime = yourSolution.NthPrime(148);

            Assert.AreEqual(857, nthPrime);
            Succeeded(3);
        }

        [Test]
        public void FourthTest()
        {
            var nthPrime = yourSolution.NthPrime(1000);

            Assert.AreEqual(7919, nthPrime);
            Succeeded(4);
        }
    }
}
