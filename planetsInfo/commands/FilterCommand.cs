using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace planetsInfo.commands
{
    class FilterCommand : ICommand
    {
        public FilterCommand(Action<FilterAstroParams_M> do_filtering)
        {
            this.FilterFunc = do_filtering;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public event Action<FilterAstroParams_M> FilterFunc;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            FilterAstroParams_M filterPrams = parameter as FilterAstroParams_M;
            FilterFunc(filterPrams);
        }
    }
}
