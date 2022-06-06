using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlP.Base;
using UserControlP.MyPageByUserControl.Stores;

namespace UserControlP.MyPageByUserControl
{
  public class MainViewModel : BaseViewModel
  {
    private readonly NavigationStore _navigationStore;
    public BaseViewModel? CurrentViewModel => _navigationStore.CurrentViewMdoel;

    public MainViewModel(NavigationStore navigation)
    {      
      _navigationStore = navigation;
      _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    private void OnCurrentViewModelChanged()
    {
      OnPropertyChanged(nameof(CurrentViewModel));
    }
  }
}
