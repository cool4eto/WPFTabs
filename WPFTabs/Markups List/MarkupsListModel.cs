using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MarkupsListModel : INotifyPropertyChanged
    {
        public bool ZoomFitMarkups { get; set; }
        public bool ShowMeasurementValueforDominantOnly { get; set; }
        public bool RichTextForComets { get; set; }
        public bool WrapCommentText { get; set; }
        public bool ExcludeFillteredMarkups { get; set; }
        public int FilteredAnnotationDim { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
