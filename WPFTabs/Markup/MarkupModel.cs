using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MarkupModel : INotifyPropertyChanged
    {
        public bool DinamiclySetAsDefault { get; set; }
        public bool ReuseTools { get; set; }
        public bool AutosizeTextBoxAndCalloutMarkups { get; set; }
        public bool ScaleApperance { get; set; }
        public bool RetainLayerInfo { get; set; }
        public bool EmbedFonts { get; set; }
        public bool ShowAuthorAndDate { get; set; }
        public bool PrintPopUps { get; set; }
        public int PopupOpacity { get; set; }
        public bool CopyHiglilitedText { get; set; }
        public ObservableCollection<string> DefaultImageEncoding { get; set; }
        public ObservableCollection<string> DragBehaviorForShapes { get; set; }
        public ObservableCollection<string> SnapShotRes { get; set; }
        public bool TakeVectorSnapshots { get; set; }
        public bool IncludeMarkupInSnapshots { get; set; }
        public bool IncludeMakrupsInSnapshotsFromSpaces { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
