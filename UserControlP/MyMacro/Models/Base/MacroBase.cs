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
    public virtual string DelaySec { get; set; } = "0";

    public virtual Task Run()
    {
      float.TryParse(DelaySec, out float sec);
      return Task.Delay((int)(sec * 1000));
    }
  }
}
