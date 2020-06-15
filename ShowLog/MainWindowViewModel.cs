using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShowLog
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<String> LogMessages { get; set; } = new ObservableCollection<string>();
        private string logMessage;

        public string LogMessage
        {
            get { return logMessage; }
            set
            {
                logMessage = value;
                OnPropertyChanged();
            }
        }


        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
