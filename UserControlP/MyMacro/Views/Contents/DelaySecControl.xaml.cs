using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlP.MyMacro.Views.Contents
{
  /// <summary>
  /// DelaySecControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class DelaySecControl : UserControl
  {
    private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      e.Handled = !IsTextAllowed(e.Text);
    }

    private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
    private static bool IsTextAllowed(string text)
    {
      return !_regex.IsMatch(text);
    }

    private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
    {
      if (e.DataObject.GetDataPresent(typeof(String)))
      {
        String text = (String)e.DataObject.GetData(typeof(String));
        if (!IsTextAllowed(text))
        {
          e.CancelCommand();
        }
      }
      else
      {
        e.CancelCommand();
      }
    }

    public DelaySecControl()
    {
      InitializeComponent();
    }



    public string DelaySec
    {
      get { return (string)GetValue(DelaySecProperty); }
      set { SetValue(DelaySecProperty, value); }
    }

    // Using a DependencyProperty as the backing store for DelaySec.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DelaySecProperty =
        DependencyProperty.Register("DelaySec", typeof(string), typeof(DelaySecControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


  }
}
