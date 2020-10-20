using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class FileAccessViewModel
    {
        public FileAccessModel Model { get; set; }
        public string SelectedHistoryLimit { get; set; }

        public FileAccessViewModel()
        {
            Model = new FileAccessModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.RecentHistoryLimit = new ObservableCollection<string>()
            { 
                "30 Days",
                "60 Days",
                "90 Days",
                "120 Days",
                "1 Year",
                "Forever"
            };

        }

        private void SelectionsForStartrup()
        {
            Model.RecentFiles = true;
            Model.ItemsInRecent = 20;
            Model.PdfPreview = true;
            SelectedHistoryLimit = Model.RecentHistoryLimit[2];
            Model.BatchCheckIn = true; 
        }
    }
}
