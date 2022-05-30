using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserControlP.MyUserControl
{
  internal class ButtonCommand : ICommand
  {
    private Action _onClick;
    public ButtonCommand(Action action)
    {
      _onClick = action;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
      return true;
    }

    public void Execute(object? parameter)
    {
      _onClick();
    }
  }
}
