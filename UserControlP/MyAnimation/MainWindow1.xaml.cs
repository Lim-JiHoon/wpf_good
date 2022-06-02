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
  /// MainWindow1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow1 : Window
  {
    public MainWindow1()
    {
      InitializeComponent();
      Loaded += (s, e) =>
      {
        var sb = new Storyboard();
        var slideAnimation = new ThicknessAnimation()
        {
          Duration = new Duration(TimeSpan.FromSeconds(1)),
          From = new Thickness(Width, 0, -Width, 0),
          To = new Thickness(0),
          DecelerationRatio = 0.9f
        };

        Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
        sb.Children.Add(slideAnimation);
        sb.Begin(this);
      };
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      frame.Navigate(new Uri("/MyAnimation/TestPage.xaml", UriKind.RelativeOrAbsolute));

     



      //DoubleAnimation da = new DoubleAnimation();
      //da.From = 50; 
      //da.To = 70; 
      //da.Duration = new Duration(TimeSpan.FromMilliseconds(500)); 
      //// 500ms == 0.5s
      //da.AutoReverse = true;
      ////da.RepeatBehavior = RepeatBehavior.Forever;
      //btn.BeginAnimation(Button.MarginProperty, da);    
    }

    private void Button_Click2(object sender, RoutedEventArgs e)
    {
      frame.Navigate(new Uri("/MyAnimation/TestPage2.xaml", UriKind.RelativeOrAbsolute));
    }
  }
}
