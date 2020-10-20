using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SketchViewModel
    {
        public SketchModel Model { get; set; }
        public string SelectedRotationInput { get; set; }
        public string SelectedEllipseMode { get; set; }
        public SketchViewModel()
        {
            Model = new SketchModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.RotationInput = new ObservableCollection<string>()
            {
                "Relative",
                "Absolute"
            };
            Model.EllipseMode = new ObservableCollection<string>()
            {
                "Width x Height",
                "Radius"
            };
        }

        private void SelectionsForStartrup()
        {
            SelectedRotationInput = Model.RotationInput[1];
            SelectedEllipseMode = Model.EllipseMode[1];
        }
    }
}
