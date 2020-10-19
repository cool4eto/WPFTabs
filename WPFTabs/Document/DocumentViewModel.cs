using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class DocumentViewModel
    {
        public Document Document { get; set; }
        public string SelectedSaveMode { get; set; }
        public string SelectedPageLayout { get; set; }
        public string SelectedSingleDisplay { get; set; }
        public string SelectedContinuousDisplay { get; set; }

        public DocumentViewModel()
        {
            Document = new Document();
            FillModel();
            SelectionsForStartrup();
        }
        private void FillModel()
        {
            Document.SaveMode = new ObservableCollection<string>()
            {
                "Mentain Revisions",
                "Publish Without Revisions",
                "Publish Compressed (1.5)"
            };

            Document.PageLayout = new ObservableCollection<string>()
            {
                "Single Page",
                "Continuous",
                "Side-by-Side",
                "Continuous Side-by-Side",
                "Document Based",
                "Auto Detect by Page Size"
            };

            Document.SingleDisplay = new ObservableCollection<string>()
            {
                "Fit Page",
                "Fit Width",
                "Actual Size"
            };

            Document.ContinuousDisplay = new ObservableCollection<string>()
            {
                 "Fit Page",
                "Fit Width",
                "Actual Size"
            };
        }

        private void SelectionsForStartrup()
        {
            Document.DocumentRecovery = false;
            SelectedSaveMode = Document.SaveMode[1];
            SelectedPageLayout = Document.PageLayout[5];
            SelectedSingleDisplay = Document.SingleDisplay[0];
            SelectedContinuousDisplay = Document.ContinuousDisplay[1];
            Document.RotateAllPages = true;
            Document.AutomaticlyReorderBookmarks = true;
            Document.RedirectLinks = true;
            Document.PromptUserForLockedFile = true;
            Document.FindHyperlinks = true;
            Document.RememberLastPage = true;
        }

        
    }
}
