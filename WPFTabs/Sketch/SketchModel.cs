using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SketchModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> RotationInput { get; set; }
        public ObservableCollection<string> EllipseMode { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
