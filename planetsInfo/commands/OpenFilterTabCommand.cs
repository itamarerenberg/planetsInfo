using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace planetsInfo.commands
{
    class OpenFilterTabCommand : ICommand
    {
        public event Action Open;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public OpenFilterTabCommand(Action open)
        {
            Open = open;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Open();
        }
    }
}
