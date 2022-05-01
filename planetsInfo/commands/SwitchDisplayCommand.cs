using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace planetsInfo.commands
{
    class SwitchDisplayCommand : ICommand
    {
        private Action<string> action;
        public event EventHandler CanExecuteChanged;

        public SwitchDisplayCommand(Action<string> action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action(parameter as string);
        }
    }
}
