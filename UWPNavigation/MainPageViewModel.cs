using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPNavigation
{
    class MainPageViewModel : ViewModelBase
    {
        string counter;
        public string Counter { get { return counter; } set { SetProperty(ref counter, value); } }
    }
}
