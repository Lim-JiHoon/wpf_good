using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyMessageBox
{
  public class MyMessageBoxViewModel
  {
    public MyMessageBoxViewModel(MsgBoxButton msgBoxButton)
    {
      this.msgBoxButton = msgBoxButton;
      Button1Command = new RelayCommand<Window>((window) => { Result = MsgBoxResult.Yes; window.Close(); });
      Button2Command = new RelayCommand<Window>((window) => { Result = MsgBoxResult.No; window.Close(); });
      Button3Command = new RelayCommand<Window>((window) => { Result = MsgBoxResult.Cancel; window.Close(); });
      SetButtonText();
    }
    private readonly MsgBoxButton msgBoxButton;

    public MsgBoxResult Result { get; private set; } = MsgBoxResult.Cancel;
    public string Title { get; set; } = "";
    public string Message { get; set; } = "";
    public ICommand Button1Command { get; set; }
    public ICommand Button2Command { get; set; }
    public ICommand Button3Command { get; set; }

    public String Button1Text { get; set; } = "";
    public String Button2Text { get; set; } = "";
    public String Button3Text { get; set; } = "";


    private void SetButtonText()
    {
      switch (msgBoxButton)
      {
        case MsgBoxButton.YesNo:
          Button1Text = "Yes";
          Button2Text = "No";
          break;
        case MsgBoxButton.YesNoCancel:
          Button1Text = "Yes";
          Button2Text = "No";
          Button3Text = "Cancel";
          break;
        case MsgBoxButton.OKCancel:
          Button1Text = "OK";
          Button2Text = "Cancel";
          break;
        default:
          Button1Text = "OK";
          break;
      }
    }
  }
}
