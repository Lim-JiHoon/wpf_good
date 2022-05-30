using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserControlP.Base
{
  public class RelayCommand : ICommand
  {
    private Action<object> action;

    public RelayCommand(Action<object> action)
    {
      this.action = action; 
    }
    public event EventHandler? CanExecuteChanged  = (s, e) => { };

    public bool CanExecute(object? parameter)
    {
      return true;
    }

    public void Execute(object? parameter)
    {
      action.Invoke(parameter!);
    }
  }
}
