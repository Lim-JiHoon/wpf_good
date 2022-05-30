using FontAwesome.WPF;
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

namespace UserControlP.MyUserControl
{
  /// <summary>
  /// UserControl1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class UserItem : UserControl
  {
    public UserItem()
    {
      InitializeComponent();
    }

    public Object MyText
    {
      get { return (string)GetValue(MyTextProperty); }
      set { SetValue(MyTextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyText.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MyTextProperty =
        DependencyProperty.Register("MyText", typeof(Object), typeof(UserItem), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));




    public ICommand MyCommand
    {
      get { return (ICommand)GetValue(MyCommandProperty); }
      set { SetValue(MyCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyCommand.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MyCommandProperty =
        DependencyProperty.Register("MyCommand", typeof(ICommand), typeof(UserItem), new UIPropertyMetadata(null));




    public FontAwesomeIcon FontAwesomeIcon
    {
      get { return (FontAwesomeIcon)GetValue(MyFontAwesomeProperty); }
      set { SetValue(MyFontAwesomeProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MyFontAwesomeProperty =
        DependencyProperty.Register("FontAwesomeIcon", typeof(FontAwesomeIcon), typeof(UserItem), new UIPropertyMetadata(FontAwesomeIcon.Git));




    public string ButtonText
    {
      get { return (string)GetValue(ButtonTextProperty); }
      set { SetValue(ButtonTextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for ButtonText.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ButtonTextProperty =
        DependencyProperty.Register("ButtonText", typeof(string), typeof(UserItem), new PropertyMetadata(string.Empty));


  }
}
