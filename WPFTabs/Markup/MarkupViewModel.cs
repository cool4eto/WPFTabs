using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MarkupViewModel
    {
        public MarkupModel Model { get; set; }
        public string SelectedDefaultImageEncoding { get; set; }
        public string SelectedDragBehaviorForShapes { get; set; }
        public string SelectedSnapShotRes { get; set; }
        public MarkupViewModel()
        {
            Model = new MarkupModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.DefaultImageEncoding = new ObservableCollection<string>()
            {
                "Auto-select",
                "Zip",
                "Jpeg",
                "Jpeg2000",
                "CCITT(G4)"
            };
            Model.DragBehaviorForShapes = new ObservableCollection<string>()
            {
                "Drag Rectangle",
                "Drag Curves"
            };
            Model.SnapShotRes = new ObservableCollection<string>()
            {
                "Screen",
                "72",
                "96",
                "120",
                "150",
                "200",
                "250",
                "300",
                "350",
                "400",
                "450",
                "600"
            };
        }

        private void SelectionsForStartrup()
        {
            Model.ScaleApperance = true;
            Model.RetainLayerInfo = true;
            Model.EmbedFonts = true;
            Model.PrintPopUps = true;
            Model.PopupOpacity = 70;
            Model.CopyHiglilitedText = true;
            SelectedDefaultImageEncoding = Model.DefaultImageEncoding[0];
            SelectedDragBehaviorForShapes = Model.DragBehaviorForShapes[0];
            SelectedSnapShotRes = Model.SnapShotRes[2];
            Model.TakeVectorSnapshots = true;
            Model.IncludeMarkupInSnapshots = true;

        }
    }
}
