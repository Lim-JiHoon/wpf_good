using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlP.MyMessageBox
{
  public enum MsgBoxResult
  {
    Yes, No, Cancel, Button1, Button2, Button3
  }

  public enum MsgBoxButton
  {
    OK = 0,
    OKCancel = 1,
    YesNoCancel = 3,
    YesNo = 4
  }
}
