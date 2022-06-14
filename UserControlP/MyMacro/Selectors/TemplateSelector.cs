using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using UserControlP.MyMacro.Models;

namespace UserControlP.MyMacro
{
  public class TemplateSelector : DataTemplateSelector
  {
    public override DataTemplate? SelectTemplate(object item, DependencyObject container)
    {
      FrameworkElement element = (FrameworkElement)container;
      MacroBase macro = (MacroBase)item;

      if (macro is MouseMacro)
      {
        return (DataTemplate)element.FindResource("MouseMacro");
      }else if (macro is SendKeysMacro)
      {
        return (DataTemplate)element.FindResource("SendKeysMacro");
      }
      return null;
      //return base.SelectTemplate(item, container);
    }
  }
}
