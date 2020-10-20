using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class MarkupsListViewModel
    {
        public MarkupsListModel Model { get; set; }

        public MarkupsListViewModel()
        {
            Model = new MarkupsListModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {

        }

        private void SelectionsForStartrup()
        {
            Model.WrapCommentText = true;
            Model.FilteredAnnotationDim = 40;
        }
    }
}
