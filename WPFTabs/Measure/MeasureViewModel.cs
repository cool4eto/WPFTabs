using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MeasureViewModel
    {
        public MeasureModel Model { get; set; }
        public string SelectedDynamicFillInput { get; set; }
        public string SelectedEdgeSensitivity { get; set; }

        public MeasureViewModel()
        {
            Model = new MeasureModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.DynamicFillInput = new ObservableCollection<string>()
            {
                "400 dpi",
                "300 dpi",
                "150 dpi",
                "96 dpi",
                "72 dpi"
            };
            Model.EdgeSensitivity = new ObservableCollection<string>()
            {
                "Low",
                "High"
            };
        }

        private void SelectionsForStartrup()
        {
            Model.AutomaticlySplitCountMeasurements = true;
            SelectedDynamicFillInput = Model.DynamicFillInput[1];
            Model.MomentlyHideMarkups = true;
            Model.FillSize = 100;
            Model.FillSpeed = 20;
            Model.BoundarySize = 100;
            SelectedEdgeSensitivity = Model.EdgeSensitivity[1];
        }
    }
}
