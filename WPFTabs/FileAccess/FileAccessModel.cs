using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class FileAccessModel : INotifyPropertyChanged
    {
        public bool RecentFiles { get; set; }
        public int ItemsInRecent { get; set; }
        public bool PdfPreview { get; set; }
        public ObservableCollection<string>  RecentHistoryLimit { get; set; }
        public bool OpenAndSaveFilesToDMS { get; set; }
        public bool AlwaysShowSelectionDIalog { get; set; }
        public bool BatchCheckIn { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
