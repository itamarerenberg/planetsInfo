using planetsInfo.commands;
using planetsInfo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;

namespace planetsInfo.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        MainWindowFinal view;
        public event PropertyChangedEventHandler PropertyChanged;
        public SwitchDisplayCommand switchDisplayCmnd;
        public SwitchDisplayCommand SwitchDisplayCmnd { get; set; }

        Dictionary<string, UserControl> panels;

        string visible;

        public MainWindowViewModel(MainWindowFinal view)
        {
            this.view = view;
            panels = new Dictionary<string, UserControl>()
            {
                ["PODPanel"] = view.PODPanel,
                ["SolarSystemPanel"] = view.SolarSystemPanel,
                ["SearchPanel"] = view.SearchPanel,
                ["AstroidPanel"] = view.AstroidPanel
            };
            this.switchDisplay("PODPanel");
            SwitchDisplayCmnd = new SwitchDisplayCommand(switchDisplay);
        }

        private void switchDisplay(string display)
        {
            if(visible != null)
                panels[visible].Visibility = Visibility.Hidden;
            panels[display].Visibility = Visibility.Visible;
            visible = display;
        }
    }
}
