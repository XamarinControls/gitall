using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GitAll.Core.ViewModels.Base
{
    public class RelayCommand : ICommand
    {
        private Action<object> _action;

        public RelayCommand(Action action)
        {
            _action = (obj) => action.Invoke(); 
        }

        public RelayCommand(Action<object> action)
        {
            _action = action;
        }
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke(parameter);
        }
    }

    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<T> _action;


        public RelayCommand(Action<T> action)
        {
            _action = action;
        }
            
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var parameterCasted = (T)Convert.ChangeType(parameter, typeof(T));

            _action?.Invoke(parameterCasted);
        }
    }
}
