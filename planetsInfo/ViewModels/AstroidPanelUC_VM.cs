using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.ViewModels
{
    class AstroidPanelUC_VM : INotifyPropertyChanged
    {
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
            model = new AstroidPanelUC_M(new DateTime(1999,12,1), new DateTime(1999, 12, 1), 0f, 2.7f, null);
        }

    }
}
