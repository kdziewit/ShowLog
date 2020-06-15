using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ShowLog
{
    class StaticTarget
    {
        public static ObservableCollection<string> StaticLogMessages { get; set; } = new ObservableCollection<string>();
    }
}
