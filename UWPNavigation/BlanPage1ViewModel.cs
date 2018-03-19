using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UWPNavigation
{
    class BlanPage1ViewModel : ViewModelBase
    {
        int counter;
        public int Counter { get { return counter; } set { SetProperty(ref counter, value); } }
        internal ICommand IncrementCommand { get; }
        public BlanPage1ViewModel()
        {
            IncrementCommand = new CommandHandler(() => Counter++);
        }
    }
}
