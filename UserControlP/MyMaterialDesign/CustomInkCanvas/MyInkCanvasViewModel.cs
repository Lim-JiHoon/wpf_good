using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using UserControlP.Base;
using static UserControlP.MyMaterialDesign.CustomInkCanvas.MyInkCanvas;

namespace UserControlP.MyMaterialDesign.CustomInkCanvas
{
  public class MyInkCanvasViewModel : BaseViewModel
  {
    public MyInkCanvasViewModel(InkCanvas inkCanvas)
    {
      ColorCommand = new RelayCommand<object>(ChangePenColor);
      EditModeCommand = new RelayCommand<object>(ChangeEditingMode);
      this.inkCanvas = inkCanvas;
    }

    public ICommand ColorCommand { get; set; }
    public ICommand EditModeCommand { get; set; }
    private readonly InkCanvas inkCanvas;

    private void ChangePenColor(object obj)
    {
      SolidColorBrush br = (SolidColorBrush)obj;
      inkCanvas.DefaultDrawingAttributes.Color = Color.FromArgb(br.Color.A, br.Color.R, br.Color.G, br.Color.B);
    }

    private void ChangeEditingMode(object obj)
    {
      string value = (string)obj;
      switch (value)
      {
        case "Ink":
          inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
          break;
        case "EraseByPoint":
          inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
          break;
        case "EraseByStroke":
          inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
          break;
        case "None":
          inkCanvas.EditingMode = InkCanvasEditingMode.None;
          break;
      }
    }
  }


}
