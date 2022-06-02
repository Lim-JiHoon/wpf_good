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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlP.MyAnimation
{
  /// <summary>
  /// TestPage.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class TestPage : Page
  {
    public TestPage()
    {
      InitializeComponent();
      Loaded += (s, e) =>
      {
        var sb = new Storyboard();
        var slideAnimation = new ThicknessAnimation()
        {
          Duration = new Duration(TimeSpan.FromSeconds(1)),
          From = new Thickness(WindowWidth, 0, -WindowWidth, 0),
          To = new Thickness(0),
          DecelerationRatio = 0.9f
        };

        Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
        sb.Children.Add(slideAnimation);
        sb.Begin(this);
      };
    }
  }
}
