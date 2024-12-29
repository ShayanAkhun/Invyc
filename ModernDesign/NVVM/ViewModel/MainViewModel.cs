using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernDesign.core;

namespace ModernDesign.NVVM.ViewModel
{
    class MainViewModel : ObserverableObject
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; }
        }






        public MainViewModel()
        {

        }

    }
}
