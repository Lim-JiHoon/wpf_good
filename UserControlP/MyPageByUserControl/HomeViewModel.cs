using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;
using UserControlP.MyPageByUserControl.Commands;
using UserControlP.MyPageByUserControl.Stores;

namespace UserControlP.MyPageByUserControl
{
  public class HomeViewModel : BaseViewModel
  {
    public string MyText { get; set; } = "HomeView";
    public ICommand NaviagteAccountCommand { get; }
    public HomeViewModel(NavigationStore navigationStore)
    {
      NaviagteAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, ()=>new AccountViewModel(navigationStore));
    }
  }
}
