using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class FormsModel : INotifyPropertyChanged
    {
        public int HighlightOpacity { get; set; }
        public bool EnableSingleKeyShortcuts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
