﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TorG.Commands;

public class RelayCommand : ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
    {
        ArgumentNullException.ThrowIfNull(execute, nameof(execute));

        _canExecute = canExecute;
        _execute = execute;
    }

    private readonly Predicate<object?>? _canExecute;
    private readonly Action<object?> _execute;

    public bool CanExecute(object? parameter) => _canExecute is null || _canExecute.Invoke(parameter);

    public void Execute(object? parameter) => _execute.Invoke(parameter);
}