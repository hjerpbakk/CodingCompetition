namespace Sidebar.DesignData
{
    class TestResultViewModelDD : TestResultViewModel
    {
        public TestResultViewModelDD() : this("En test")
        {
            
        }

        public TestResultViewModelDD(string name)
        {
            Name = name;
        }
    }
}
