using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using UserControlP.Base;
using UserControlP.MyMacro.Models;

namespace UserControlP.MyMacro.ViewModels
{
  public class SendKeysControlViewModel : MacroBase
  {
    private string GetKeysString()
    {
      return SendKeysAction == SendKeysAction.SendKeys? Keys :Regex.Replace(Keys, "[+^%~(){}]", "{$0}");
    }
    public SendKeysControlViewModel()
    {
      SendKeysActionCommand = new RelayCommand<SendKeysAction>(action => SendKeysAction = action);
    }
    public string Keys { get; set; } = "";
    public async override Task Run()
    {
      await base.Run();      
      await Task.Run(() => SendKeys.SendWait(GetKeysString()));
    }

    public ICommand SendKeysActionCommand { get; set; }
    public SendKeysAction SendKeysAction { get; set; } = SendKeysAction.SendKeys;
  }
}
