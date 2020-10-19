using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SpellingTab : INotifyPropertyChanged
    {
        public bool AutoComplete { get; set; }
        public bool SpellCheck { get; set; }
        public bool UpperCaseWords { get; set; }
        public ObservableCollection<string> Dictionary { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
