using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
using planetsInfo.commands;
using planetsInfo.View;

namespace planetsInfo.ViewModels
{
    class AstroidPanelUC_VM : INotifyPropertyChanged
    {


        #region filter
        OpenFilterTabCommand openFilterTab;
        public OpenFilterTabCommand OpenFilterTab
        {
            get
            {
                return openFilterTab;
            }
            set
            {
                openFilterTab = value;
            }
        }

        #endregion
       
        
        AstroidPanelUC_M model;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> AstroidsNames 
        {
            get => new ObservableCollection<string>(model.Astroids.Select(A => A.name));
        }

        string selectedAstroidName;

        public string SelectedAstroidName 
        {
            get => selectedAstroidName;
            set
            {
                selectedAstroidName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedAstroidName)));
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedAstroid)));
                }
            }
        }

        public AstroidViewModel SelectedAstroid
        {
            get
            {

                if (selectedAstroidName == null)
                    return null;
                return new AstroidViewModel(model.Astroids.First(a => a.name == selectedAstroidName));
            }
           
        }

        public AstroidPanelUC_VM()
        {
            model = new AstroidPanelUC_M();
            openFilterTab = new OpenFilterTabCommand(open_filter_tab);
            loadData(new FilterAstroParams_M()); // default values
        }

        private void open_filter_tab()
        {
            FilterTabWindow filterTab = new FilterTabWindow(loadData);
            filterTab.ShowDialog();
        }

        void loadData(FilterAstroParams_M filterParams)
        {
            Task loader = Task.Factory.StartNew(() => model.LoadData(
                filterParams.from,
                filterParams.until,
                filterParams.min_diameter,
                filterParams.max_diameter,
                filterParams.isDengarouse
                ));
            loader.ContinueWith((t) =>
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(""));//all properties has changed
            });
        }

    }
}
