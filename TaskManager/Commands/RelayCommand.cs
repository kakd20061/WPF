using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskManager.Commands
{
    class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _excute { get; set; }
        private Predicate<object> _canExcute { get; set; }


        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {

            _excute = executeMethod;
            _canExcute = canExecuteMethod;

        }

        public bool CanExecute(object? parameter)
        {
            return _canExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _excute(parameter);
        }
    }
}
