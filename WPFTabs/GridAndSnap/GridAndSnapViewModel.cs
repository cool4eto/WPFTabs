using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class GridAndSnapViewModel
    {
        public GridAndSnap GridAndSnap { get; set; }
        public string SelectedUnit { get; set; }

        public GridAndSnapViewModel()
        {
            GridAndSnap = new GridAndSnap();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            GridAndSnap.Units = new ObservableCollection<string>()
            {
                "Inches",
                "Centimeters",
                "Milimeters",
                "Points"
            };
        }

        private void SelectionsForStartrup()
        {
            SelectedUnit = GridAndSnap.Units[1];
            GridAndSnap.GridSpacing = 0.25m;
            GridAndSnap.SnapToLines = true;
            GridAndSnap.SnapToCurves = true;
            GridAndSnap.SnapToMidPoints = true;
            GridAndSnap.SnapToEndPoints = true;
            GridAndSnap.SnapToIntersections = true;
            GridAndSnap.SnapToPageBoundaries = true;
            GridAndSnap.IgnoreTinyLine = true;
            GridAndSnap.Sensitivity = 10;
        }
    }
}
