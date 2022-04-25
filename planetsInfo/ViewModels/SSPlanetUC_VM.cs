using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace planetsInfo.ViewModel
{
    class SSPlanetUC_VM : INotifyPropertyChanged
    {
        SSPanelUC_M model;
        public event PropertyChangedEventHandler PropertyChanged;

        string selectedItem;
        public string SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedPlanet)));
            }
        }

        public PlanetInfo_UC_VM SelectedPlanet
        {
            get
            {
                if (selectedItem == null)
                    return null;
                return new PlanetInfo_UC_VM(SelectedItem);
            }
        }

        public ObservableCollection<string> planets
        {
            get => model.planets;
            set
            {
                model.planets = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(planets)));

            }
        }

        public SSPlanetUC_VM()
        {
            model = new SSPanelUC_M();
        }
    }
}
