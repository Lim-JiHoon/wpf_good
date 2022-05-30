using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyUserControl
{
  internal class MainViewModel : BaseViewModel
  {
    private string id = "";

    public string Id
    {
      get { return id; }
      set
      {
        id = value;
        OnPropertyChanged(nameof(id));
      }
    }

    public FontAwesomeIcon FontAwesomeIcon { get; set; } = FontAwesomeIcon.Git;

    public MainViewModel()
    {
      ButtonCommand = new ButtonCommand(() =>
      {
        MessageBox.Show(id);
      });
    }

    public ICommand ButtonCommand { get; set; }
  }
}
