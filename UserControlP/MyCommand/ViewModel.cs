using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyCommand
{
  public class ViewModel : BaseViewModel
  {
    public ViewModel()
    {
      Emps = new ObservableCollection<Emp>();
      AddEmpCommand = new RelayCommand((param) => Emps.Add(new Emp() { Name = param.ToString()!, Job = "신규직업" }));
      TestCommand = new RelayCommand((param) => Console.WriteLine(param.ToString()));
      Emps.Add(new Emp() { Name= "하하" , Job = "낚시꾼"});
      Emps.Add(new Emp() { Name = "강호동", Job = "씨름선수" });
    }
    public ObservableCollection<Emp> Emps { get; set; }
    public Emp? SelectedEmp { get; set; } = null;

    public ICommand AddEmpCommand { get; set; }
    public ICommand TestCommand { get; set; }
  }
}
