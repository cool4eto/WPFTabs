using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WPFTabs
{
    sealed class OptionsViewModel
    {
        public Options options { get; set; }

        public Language SelectedLanguage { get; set; }

        public string SelectedTheme { get; set; }
        public string SelectedTabTruncation { get; set; }
        public string SelectedStartupMode { get; set; }





        public OptionsViewModel()
        {
            options = new Options();
            fillModel();
            SelectionsForStartrup();           
        }

        // Puts data in the fields
        public void fillModel()
        {
            options.Languages = new List<Language>()
            {
                new Language(){ ID = "1" , Name = "Dansk" }
                ,new Language() { ID = "2" , Name = "Nederlands"}
                ,new Language() { ID = "3" , Name = "English(UK)"}
                ,new Language() { ID = "4", Name = "English(US)" }
                ,new Language() { ID = "5" , Name = "Suomi"}
                ,new Language() { ID = "6" , Name = "Français"}
                ,new Language() { ID = "8" , Name = "Deutsch"}
                ,new Language() { ID = "9" , Name = "Italiano"}
                ,new Language() { ID = "10" , Name = "Svenska"}

            };

            options.Themes = new ObservableCollection<string>()
            {
                "Light",
                "Dark"
            };
            options.TabTruncation = new ObservableCollection<string>()
            { 
                "Start",
                "End"
            };
            options.StartupMode = new ObservableCollection<string>()
            { 
                "Markup",
                "View",
                "Last Used"
            };


        }

        public void SelectionsForStartrup()
        {
            options.UserName = "Angel Kirov";
            SelectedLanguage = options.Languages.Find(l => l.ID == "4");
            SelectedTheme = options.Themes[0];
            SelectedTabTruncation = options.TabTruncation[0];
            options.FullScreenCrosshair = true;
            SelectedStartupMode = options.StartupMode[2];
            options.ToggleFullScreen = true;
            options.ReopenFiles = true;
            options.OpenHomePage = true;
            options.ShowRecent = true;
            options.HelpBluebeam = true;
        }
    }
}