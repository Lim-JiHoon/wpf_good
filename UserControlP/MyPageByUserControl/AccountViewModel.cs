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
  public class AccountViewModel : BaseViewModel
  {
    public string MyText { get; set; } = "AccountView";
    public ICommand NavigateHomeCommand { get; }

    public AccountViewModel(NavigationStore navigationStore)
    {
      NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, ()=>new HomeViewModel(navigationStore));
    }
  }
}
