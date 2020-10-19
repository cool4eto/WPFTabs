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
    public class Navigation : INotifyPropertyChanged
    {
        public ObservableCollection<string> SinglePageMode { get; set; }
        public ObservableCollection<string> ContinuousMode { get; set; }
        public bool ReverseMouseWheel { get; set; }
        public int Sensitivity { get; set; }

        public bool HorizontalScroll { get; set; }
        public bool HorizontalMouseWheel { get; set; }
        public bool VertiaclScrollBar { get; set; }
        public bool VerticalScrollBarOnLeft { get; set; }
        public bool LockPanning { get; set; }
        public bool SynchronizeViews { get; set; }
        public ObservableCollection<string> SyncMode { get; set; }
        public bool Mouse3D { get; set; }
        public bool KeyboardAccelerators { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
