using HoonsLib.WPF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;
using UserControlP.MyMacro.ViewModels;

namespace UserControlP.MyMacro.ViewModels
{
  public class ViewModel : BaseViewModel
  {
    private bool stopCalled = false;
    private void KeyDownEvent(KeyEventArgs e)
    {
      switch (e.Key)
      {
        case Key.Delete:
          if (SelectedMacroBase != null)
            MacroBases.Remove(SelectedMacroBase);
          break;
      }
    }

    private async Task Run()
    {
      do
      {
        SelectedIndex = 0;
        foreach (var macro in MacroBases)
        {
          if (stopCalled) goto stop;
          await macro.Run();
          SelectedIndex++;
        }
      } while (IsRepeat);
    stop:
      stopCalled = false;
    }

    private void SaveMethod(object _)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == true)
      {

      }
    }

    private void LoadMethod(object _)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      if (sfd.ShowDialog() == true)
      {

      }
    }

    private void OnHotKeyStartHandler(HotkeyMaker hotKey)
    {
      Task.WhenAny(Run());
    }

    private void OnHotKeyStopHandler(HotkeyMaker hotKey)
    {
      stopCalled = true;
    }


    public ViewModel()
    {
      var hotkey = new HotkeyMaker(Key.F1, KeyModifier.NoRepeat, OnHotKeyStartHandler);
      var hotkeyF2 = new HotkeyMaker(Key.F2, KeyModifier.NoRepeat, OnHotKeyStopHandler);

      MacroBases = new ObservableCollection<MacroBase>();
      MacroKeyCommand = new RelayCommand<object>(obj => MacroBases.Add(new SendKeysControlViewModel()));
      MacroMouseCommand = new RelayCommand<object>(obj => MacroBases.Add(new MouseControlViewModel()));
      KeyDownCommand = new RelayCommand<KeyEventArgs>(KeyDownEvent);
      RunCommand = new RelayCommand<object>(async (obj) => { await Run(); });
      SaveCommand = new RelayCommand<object>(SaveMethod);
      LoadCommand = new RelayCommand<object>(LoadMethod);
    }

    public ObservableCollection<MacroBase> MacroBases { get; set; }
    public MacroBase? SelectedMacroBase { get; set; } = null;
    public ICommand MacroKeyCommand { get; set; }
    public ICommand MacroMouseCommand { get; set; }
    public ICommand KeyDownCommand { get; set; }
    public ICommand RunCommand { get; set; }
    public ICommand SaveCommand { get; set; }
    public ICommand LoadCommand { get; set; }
    public int SelectedIndex { get; set; }
    public bool IsRepeat { get; set; }
  }

}
