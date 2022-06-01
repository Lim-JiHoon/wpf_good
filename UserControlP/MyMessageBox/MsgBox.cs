using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UserControlP.MyMessageBox
{
  public class MsgBox
  {
    public static MsgBoxResult Show(string title, string message, MsgBoxButton msgBoxButton = MsgBoxButton.OK)
    {
      MessageBoxEx messageBoxEx = new MessageBoxEx() { DataContext =new MyMessageBoxViewModel(msgBoxButton) {  Title = title, Message = message } };
      messageBoxEx.Owner = Application.Current.MainWindow;
      messageBoxEx.WindowStartupLocation = WindowStartupLocation.CenterOwner;
      messageBoxEx.ShowDialog();
      return ((MyMessageBoxViewModel)messageBoxEx.DataContext).Result;

    }
  }
}
