using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class FormsViewModel
    {
        public FormsModel Model { get; set; }
        public FormsViewModel()
        {
            Model = new FormsModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
           
        }

        private void SelectionsForStartrup()
        {
            Model.HighlightOpacity = 25;
        }
    }
}
