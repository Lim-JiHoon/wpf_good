using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlP.Base;
using UserControlP.MyPageByUserControl.Stores;

namespace UserControlP.MyPageByUserControl.Commands
{
  public class NavigateCommand<TViewModel> : BaseCommand
    where TViewModel : BaseViewModel
  {
    private readonly NavigationStore _navigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
      _navigationStore = navigationStore;
      _createViewModel = createViewModel;
    }

    public override void Execute(object? parameter)
    {
      _navigationStore.CurrentViewMdoel = _createViewModel();
    }
  }
}
