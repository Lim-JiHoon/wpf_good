using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyModelBindingCall
{
  public class ViewModel : BaseViewModel
  {
    public ViewModel()
    {
      MyModel = new() { Name = "가나다", Description = "ㅎㅎㅎㅎㅎ" };
      MouseUpCommand = new RelayCommand<object>((obj) => { Console.WriteLine(obj); });
    }
    public Model MyModel { get; set; }
    public ICommand MouseUpCommand { get; set; }
  }
}
