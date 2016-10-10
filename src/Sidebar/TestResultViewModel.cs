using NDC2015;

namespace Sidebar
{
    public class TestResultViewModel : ViewModelBase
    {
        private string name;
        private bool result;

        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }

        public bool Result
        {
            get { return result; }
            set { Set(ref result, value); }
        }
    }
}
