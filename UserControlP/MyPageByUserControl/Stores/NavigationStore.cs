using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlP.Base;

namespace UserControlP.MyPageByUserControl.Stores
{
  public class NavigationStore
  {
    public event Action? CurrentViewModelChanged;
    private BaseViewModel? _currentViewModel;
    public BaseViewModel? CurrentViewMdoel
    {
      get => _currentViewModel;
      set
      {
        _currentViewModel = value;
        OnCurrentViewModelChanged();
      }

    }

    private void OnCurrentViewModelChanged()
    {
      CurrentViewModelChanged?.Invoke();
    }
  }
}
