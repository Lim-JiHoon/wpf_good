using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace UserControlP.MyMacro.Models
{
  public class SendKeysMacro : MacroBase
  {
    public string Keys { get; set; } = "";    
    public async override Task Run()
    {
      await base.Run();
      await Task.Run(() => SendKeys.SendWait(Keys));
    }
  }
}
