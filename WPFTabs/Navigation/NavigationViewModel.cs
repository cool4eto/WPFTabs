using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class NavigationViewModel
    {
        public Navigation Navigation { get; set; }

        public string SelectedSinglePageMode { get; set; }
        public string SelectedContinuousMode { get; set; }
        public string SelectedSync { get; set; }

        public NavigationViewModel()
        {
            Navigation = new Navigation();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Navigation.SinglePageMode = new ObservableCollection<string>()
            {
                "Scroll",
                "Zoom"
            };

            Navigation.ContinuousMode = new ObservableCollection<string>()
            {
                "Scroll",
                "Zoom"
            };

            Navigation.SyncMode = new ObservableCollection<string>()
            {
                "Document",
                "Page"
            };
        }

        private void SelectionsForStartrup()
        {
            SelectedSinglePageMode = Navigation.SinglePageMode[1];
            SelectedContinuousMode = Navigation.ContinuousMode[0];
            Navigation.ReverseMouseWheel = false;
            Navigation.Sensitivity = 4;
            Navigation.LockPanning = true;
            SelectedSync = Navigation.SyncMode[0];
            Navigation.Mouse3D = true;
        }
    }
}
