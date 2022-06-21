using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlP.MyMacro.Converters;
using UserControlP.MyMacro.Models;

namespace UserControlP.MyMacro.ViewModels
{
  public class LoadLogic
  {
    private List<Macro> macros;

    public LoadLogic(List<Macro> macros)
    {
      this.macros = macros;
    }

    public IEnumerable<MacroBase> GetMacroBases()
    {
      List<MacroBase> macroBases = new List<MacroBase>();
      MacroBase macroBase;
      foreach (Macro macro in macros)
      {
        switch (macro.Kind)
        {
          case "sendkeys":
            macroBase = new SendKeysControlViewModel()
            {              
              Keys = macro.Text,
              SendKeysAction = SendKeysActionConverter.StringToEnum(macro.Action),
              DelaySec = macro.Delay.ToString()
            };
            break;
          case "mouse":
            macroBase = new MouseControlViewModel()
            {
              Point= macro.Point,
              MouseAction = MouseActionConverter.StringToEnum(macro.Action),              
              DelaySec = macro.Delay.ToString()
            };

            break;
          default:
            continue;
        }
        macroBases.Add(macroBase);
      }

      return macroBases;
    }
  }
}
