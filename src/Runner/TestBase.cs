using System;

namespace Runner
{
    public class TestBase
    {
        public const int NumberOfTests = 5;

        private static readonly Lazy<int[]> results;

        static TestBase()
        {
            results = new Lazy<int[]>(() => new int[NumberOfTests]);
        }

        protected void Succeeded(int n)
        {
            results.Value[--n] = 1;
        }

        protected static void TestsEnded()
        {
            var resultString = string.Join(",", results.Value);
            new Communicator().Write(resultString);
        }
    }
}
