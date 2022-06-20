using HoonsLib.MySqlEx;
using HoonsLib.SqLiteEx;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserControlP.MyMacro.ViewModels;

namespace UserControlP.MyMacro
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
     
    private void Button_Click(object sender, RoutedEventArgs e)
    {
      lb.SelectedIndex = 1;
    }

    public void SendKey(Key key)
    {
      if (Keyboard.PrimaryDevice != null)
      {
        if (Keyboard.PrimaryDevice.ActiveSource != null)
        {
          var e1 = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, key)
          {
            RoutedEvent = Keyboard.KeyDownEvent,
            Source = lb.SelectedItem
          };
          InputManager.Current.ProcessInput(e1);
        }
      }
    }



    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct InputKeys
    {
      public uint type;
      public uint wVk;
      public uint wScan;
      public uint dwFlags;
      public uint time;
      public uint dwExtra;
    }

    const uint INPUT_KEYBOARD = 1;
    const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
    const uint KEYEVENTF_KEYUP = 0x0002;


    [DllImport("User32.DLL", EntryPoint = "SendInput")]
    public static extern uint SendInput(uint nInputs, InputKeys[] inputs, int cbSize);
  }
}
