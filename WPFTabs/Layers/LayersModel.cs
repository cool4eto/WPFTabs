using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class LayersModel : INotifyPropertyChanged
    {
        public bool HideChildLayers { get; set; }
        public bool ShowLayersOnPageOnly { get; set; }
        public ObservableCollection<string> Dials { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
