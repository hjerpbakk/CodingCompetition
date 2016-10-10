using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDC2015.DesignData
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
