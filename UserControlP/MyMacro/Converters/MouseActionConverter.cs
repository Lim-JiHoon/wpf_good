using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using UserControlP.MyMacro.Models;

namespace UserControlP.MyMacro.Converters
{
  public class MouseActionConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var mouseAction = (MouseControlAction)value;
      var param = (MouseControlAction)parameter;
      return mouseAction == param;   
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.Equals(true) ? parameter : Binding.DoNothing;
    }
  }
}
