using HoonsLib.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base; 
using UserControlP.MyMacro.Models;

namespace UserControlP.MyMacro.ViewModels
{
  public class ViewModel : BaseViewModel
  {
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
      foreach (var macro in MacroBases)
      {
        await macro.Run();
        //if (macro is KeyPress)
        //{

        //}
        //else if (macro is MousePointer)
        //{

        //}
      }
    }


    private void OnHotKeyHandler(HotkeyMaker hotKey)
    {
      Task.WhenAny(Run());      
    }

    public ViewModel()
    {
      var hotkey = new HotkeyMaker(Key.F1, KeyModifier.NoRepeat, OnHotKeyHandler);

      MacroBases = new ObservableCollection<MacroBase>();
      MacroKeyCommand = new RelayCommand<object>(obj => MacroBases.Add(new SendKeysMacro()));
      MacroMouseCommand = new RelayCommand<object>(obj => MacroBases.Add(new MouseMacro()));
      KeyDownCommand = new RelayCommand<KeyEventArgs>(KeyDownEvent);
      RunCommand = new RelayCommand<object>(async(obj) => { await Run(); });      
    }

    public ObservableCollection<MacroBase> MacroBases { get; set; }
    public MacroBase? SelectedMacroBase { get; set; } = null;
    public ICommand MacroKeyCommand { get; set; }
    public ICommand MacroMouseCommand { get; set; }
    public ICommand KeyDownCommand { get; set; }
    public ICommand RunCommand { get; set; }
  }

}
