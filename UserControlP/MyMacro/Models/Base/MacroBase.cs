using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlP.Base;

namespace UserControlP.MyMacro
{
  public abstract class MacroBase : BaseViewModel
  {
    public virtual float DelaySec { get; set; } = 0;

    public virtual Task Run()
    {
      return Task.Delay((int)(DelaySec * 1000));
    }
  }
}
