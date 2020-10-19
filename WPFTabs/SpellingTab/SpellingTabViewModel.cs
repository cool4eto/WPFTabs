using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTabs
{
    public class SpellingTabViewModel
    {
        public SpellingTab Spelling { get; set; }
        public string SelectedDictionary { get; set; }
        public SpellingTabViewModel()
        {
            Spelling = new SpellingTab();
            FillModel();
            SelectionsForStartrup();
        }

        private void FillModel()
        {
            Spelling.Dictionary = new ObservableCollection<string>()
            {
                "Dansk",
                "Nederlands",
                "English(UK)",
                "English(US)",
                "Suomi",
                "Français",
                "Deutsch",
                "Italiano",
                "Svenska"
            };
        }

        private void SelectionsForStartrup()
        {  
            Spelling.AutoComplete = true;
            Spelling.SpellCheck = true;
            SelectedDictionary = Spelling.Dictionary[3];
        }
    }
}
