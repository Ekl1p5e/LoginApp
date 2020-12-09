using System;
using System.Windows.Input;

namespace LoginApp.ViewModels.Commands
{
    public class BasicCommand : ICommand
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _predicate;

        public BasicCommand(Action<object> action, Func<object, bool> predicate)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
            _predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
