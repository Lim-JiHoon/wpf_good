using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserControlP.MyCommand
{
  internal class RelayCommand : ICommand
  {
    private Action<object>? executeAction;
    private Func<object, bool>? canExecute;

    public event EventHandler? CanExecuteChanged 
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object>? executeAction) : this(executeAction, null)
    {

    }
    public RelayCommand(Action<object>? executeAction, Func<object, bool>? canExcute)
    {
      this.executeAction = executeAction;
      this.canExecute = canExcute;
    }
    public bool CanExecute(object? parameter)
    {
      if (parameter == null || parameter?.ToString()?.Length == 0) return false;
      bool result = canExecute == null ? true : canExecute(parameter);
      return result;
    }

    public void Execute(object? parameter)
    {
      if (executeAction != null)
         executeAction(parameter!);
    }
  }
}
