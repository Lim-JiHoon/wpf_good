using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserControlP.Base;

namespace UserControlP.MyListView
{
  public class ViewModel : BaseViewModel
  {
    public ObservableCollection<Model> Students { get; set; } = new ObservableCollection<Model>();
    public ViewModel()
    {
      Students.Add(new Model() { Name = "김나래", Gender = "여", Age = 30 });
      Students.Add(new Model() { Name = "박수홍", Gender = "남", Age = 11 });
      Students.Add(new Model() { Name = "안철수", Gender = "남", Age = 20 });
      Students.Add(new Model() { Name = "김훈수", Gender = "남", Age = 45 });

      AddStudentCommand = new AddStudentCommand(() =>
      {
        Students.Add(new Model() { Name = "세계관 최강자", Gender = "남", Age = 123456 });
      });
    }

    public ICommand AddStudentCommand { get; set; }
    //private readonly ModelList students;

    //public ViewModel()
    //{
    //  this.students = new ModelList();
    //}

    //public ModelList Students
    //{
    //  get { return this.students; }
    //}
  }
}
