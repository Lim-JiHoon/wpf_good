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
using System.Windows.Shapes;

namespace UserControlP.MyModelBindingCall
{
  /// <summary>
  /// Window1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Window1 : Window
  {
    public Window1()
    {
      InitializeComponent();
      DataContext = new ViewModel();
    }

    private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
    {

    }

    private void StackPanel_MouseUp_1(object sender, MouseButtonEventArgs e)
    {

    }
  }
}
