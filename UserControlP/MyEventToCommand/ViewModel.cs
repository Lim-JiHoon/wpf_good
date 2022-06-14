using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyEventToCommand
{
  public class ViewModel
  {
    public ViewModel()
    {
      MouseWheelCommand = new RelayCommand<object>((arg) => { Console.Write(arg.ToString()); });
    }

    public ICommand MouseWheelCommand { get; set; }
  }
}
