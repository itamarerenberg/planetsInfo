using planetsInfo.commands;
using planetsInfo.Model;
using planetsInfo.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace planetsInfo.ViewModels
{
    class NEOUC_VM
    {
        FilterCommand filterCmnd;
        FilterUserControl view;
        public FilterCommand FilterCmnd
        {
            get => filterCmnd;
            set => filterCmnd = value;
        }
        Action<FilterAstroParams_M> filterAction;

        public NEOUC_VM(FilterUserControl view, Action<FilterAstroParams_M> filter)
        {
            FilterCmnd = new FilterCommand(do_filtering);
            filterAction = filter;
            this.view = view;
        }

        void do_filtering(FilterAstroParams_M filterPrams)
        {
            filterAction(filterPrams);
            view.Visibility=Visibility.Hidden;
        }
    }
}
