using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UserControlP.MyUserControl
{
  /// <summary>
  /// Window1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Window1 : Window
  {
    private ObservableCollection<Model> _models = new ObservableCollection<Model>();
    public IEnumerable<Model> Models => _models;
   
    public Window1()
    {
      InitializeComponent();     
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      DateTime dt = DateTime.Now; 

      for (int i = 0; i < 5; i++)
      {
      _models.Add(new Model() { TItle = dt.ToString("yyyy-MM-dd"), Image = new BitmapImage(new Uri(@"C:\Users\RENEWCOM PC\Pictures\notitle.png")) }); ;
        dt = dt.AddMonths(1);
      }
    }
  }

  public class Model
  {
    public string TItle { get; set; } = "";
    public BitmapImage? Image { get; set; } = null;
  }
}
