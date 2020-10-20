using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MeasureModel : INotifyPropertyChanged
    {
        public bool AutomaticlySplitCountMeasurements { get; set; }
        public ObservableCollection<string> DynamicFillInput { get; set; }
        public bool MomentlyHideMarkups { get; set; }
        public int FillSize { get; set; }
        public int FillSpeed { get; set; }
        public int BoundarySize { get; set; }
        public ObservableCollection<string> EdgeSensitivity { get; set; }
        public bool LegacyPersist { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
