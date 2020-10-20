using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class LayersViewModel
    {
        public LayersModel Model { get; set; }
        public string SelectedDial { get; set; }

        public LayersViewModel()
        {
            Model = new LayersModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.Dials = new ObservableCollection<string>()
            {
                "Isolate",
                "Build",
                "Select"
            };
        }

        private void SelectionsForStartrup()
        {
            Model.HideChildLayers = true;
            SelectedDial = Model.Dials[0];
        }
    }
}
