using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SignatureViewModel
    {
        public SignatureModel Model { get; set; }
        public string SelectedAlgorithm { get; set; }
        public SignatureViewModel()
        {
            Model = new SignatureModel();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Model.DigitalIdLocation = "File Path";
            Model.TrustedIdLocation = "File Path";
            Model.Algorithm = new ObservableCollection<string>()
            {
                "SHA-1",
                "SHA-256"
            };
        }

        private void SelectionsForStartrup()
        {
            Model.PassTimeout = 5;
            SelectedAlgorithm = Model.Algorithm[1];
            Model.RestrictChangesThatInvalidateDigitalSignatures = true;
        }
    }
}
