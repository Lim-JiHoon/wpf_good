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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserControlP.MyAnimation
{
  /// <summary>
  /// Window1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Window1 : Window
  {
    public Window1()
    {
      InitializeComponent();
      orgGridWidth = gridMain.ColumnDefinitions[0].Width;
    }

    GridLength orgGridWidth;
    int minPanelWidth = 30;

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Storyboard storyboard = new Storyboard();
      var gla = new GridLengthAnimation()
      {        
        Duration = new Duration(TimeSpan.FromSeconds(1)),
        From = new GridLength(1, GridUnitType.Star),
        To = new GridLength(2, GridUnitType.Star),
        FillBehavior = FillBehavior.HoldEnd
      };
      Storyboard.SetTargetName(gla, col0.Name);
      Storyboard.SetTargetProperty(gla, new PropertyPath("Width"));
      storyboard.Completed += (sender, e) =>
      {
        btn.Content = 123;
      };
      storyboard.Children.Add(gla);
      storyboard.Begin(col0);
    }
  }
}
