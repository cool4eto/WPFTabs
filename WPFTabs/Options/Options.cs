using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class Options : INotifyPropertyChanged
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<Language> Languages { get; set; }
        public ObservableCollection<string> Themes { get; set; }
        public ObservableCollection<string> TabTruncation { get; set; }
        public bool FullScreenCrosshair { get; set; }
        public ObservableCollection<string> StartupMode { get; set; }
        public bool ToggleFullScreen { get; set; }
        public bool ReopenFiles { get; set; }
        public bool OpenHomePage { get; set; }
        public bool ShowRecent { get; set; }
        public bool HelpBluebeam { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
