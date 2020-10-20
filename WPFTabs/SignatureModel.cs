using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SignatureModel : INotifyPropertyChanged
    {
        public int PassTimeout { get; set; }
        public string DigitalIdLocation { get; set; }
        public string TrustedIdLocation { get; set; }
        public ObservableCollection<string> Algorithm { get; set; }
        public bool RestrictChangesThatInvalidateDigitalSignatures { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
