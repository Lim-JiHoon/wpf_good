using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserControlP.Base
{
  public class RelayCommand<T> : ICommand    
  {
    private Action<T> action;

    public RelayCommand(Action<T> action)
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
      action?.Invoke((T)parameter!);
    }
  }
}
