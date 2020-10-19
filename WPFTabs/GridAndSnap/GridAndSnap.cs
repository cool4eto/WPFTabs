using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class GridAndSnap : INotifyPropertyChanged
    {
        public ObservableCollection<string> Units { get; set; }
        public bool ShowGrid{ get; set; }
        public bool SnapToGrid { get; set; }
        public decimal GridSpacing { get; set; }
        public bool SnapToContext { get; set; }
        public bool SnapToMarkup { get; set; }
        public bool SnapToLines { get; set; }
        public bool SnapToCurves { get; set; }
        public bool SnapToMidPoints { get; set; }
        public bool SnapToEndPoints { get; set; }
        public bool SnapToIntersections { get; set; }
        public bool SnapToPageBoundaries { get; set; }
        public bool IgnoreTinyLine { get; set; }
        public int Sensitivity { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
