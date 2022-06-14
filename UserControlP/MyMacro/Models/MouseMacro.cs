using HoonsLib.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wf = System.Windows.Forms;

namespace UserControlP.MyMacro.Models
{
  public class MouseMacro : MacroBase
  {
    [DllImport("User32.dll")]
    private static extern bool SetCursorPos(int X, int Y);

    public MouseMacro()
    {

    }

    public async override Task Run()
    {
      await base.Run();
      await Task.Run(() => {
        wf.Cursor.Position = Point;
      });
    }
    public Point Point { get; set; }
  }
}
