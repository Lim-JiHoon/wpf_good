using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using UserControlP.MyMessageBox;
using UserControlP.MyUserControl;

namespace UserControlP
{
  /// <summary>
  /// Window1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Window1 : Window
  {
    public Window1()
    {
      InitializeComponent();

      var useritem = new UserItem();
      grid1.Children.Add(useritem);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      var t = MsgBox.Show("우", "오늘두", MsgBoxButton.YesNoCancel);
      Debug.WriteLine(t.ToString());
    }
  }
}
