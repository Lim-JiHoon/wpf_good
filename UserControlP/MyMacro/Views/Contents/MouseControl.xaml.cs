using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using UserControlP.Base;
using WinForm= System.Windows.Forms;
namespace UserControlP.MyMacro.Views.Contents
{
  /// <summary>
  /// MouseControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MouseControl : UserControl
  {
    public MouseControl()
    {
      InitializeComponent();

      MousePointSetCommand = new RelayCommand<object>((obj) => { txtPoint.Text = $"{WinForm.Cursor.Position.X},{WinForm.Cursor.Position.Y}"; });
      KeyGesture findKeyGesture = new KeyGesture(Key.S, ModifierKeys.Shift | ModifierKeys.Alt);
      KeyBinding findKeyBinding = new KeyBinding(MousePointSetCommand, findKeyGesture);
      InputBindings.Add(findKeyBinding);
    }

    ICommand MousePointSetCommand { get; set; }



    public string MousePoint
    {
      get { return (string)GetValue(MousePointProperty); }
      set { SetValue(MousePointProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MousePoint.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MousePointProperty =
        DependencyProperty.Register("MousePoint", typeof(string), typeof(MouseControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


  }
}
