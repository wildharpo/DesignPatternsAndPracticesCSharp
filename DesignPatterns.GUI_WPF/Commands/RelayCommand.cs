﻿using System.Windows.Input;

namespace DesignPatterns.GUI_WPF.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        public RelayCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }
        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) => _executeAction(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
