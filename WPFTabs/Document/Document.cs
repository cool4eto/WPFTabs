using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class Document : INotifyPropertyChanged
    {
        public bool DocumentRecovery { get; set; }
        public ObservableCollection<string> SaveMode { get; set; }
        public ObservableCollection<string> PageLayout { get; set; }
        public ObservableCollection<string> SingleDisplay { get; set; }
        public ObservableCollection<string> ContinuousDisplay { get; set; }
        public int MaximumZoom { get; set; }
        public bool RotateAllPages { get; set; }
        public bool AutomaticlyReorderBookmarks { get; set; }
        public bool RedirectLinks { get; set; }
        public bool PromptUserForLockedFile { get; set; }
        public bool FindHyperlinks { get; set; }
        public bool RememberLastPage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
