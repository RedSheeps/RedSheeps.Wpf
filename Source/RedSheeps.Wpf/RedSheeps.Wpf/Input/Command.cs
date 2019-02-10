using System;
using System.Windows.Input;

namespace RedSheeps.Wpf.Input
{
    public class Command : ICommand
    {
        private readonly Action<object> _execute;

        public Command(Action<object> execute)
        {
            _execute = execute;
        }

        public Command(Action execute) : this(_ => execute())
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }

    public class Command<T> : Command where T : class
    {
        public Command(Action<T> execute) 
            : base(param => execute(param as T)) 
        {
        }
    }
}
