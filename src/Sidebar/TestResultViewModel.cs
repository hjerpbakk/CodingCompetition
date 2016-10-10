using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using NDC2015.Annotations;

namespace NDC2015
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
