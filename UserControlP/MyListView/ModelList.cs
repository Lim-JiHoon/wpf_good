using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlP.MyListView
{
  public class ModelList : ObservableCollection<Model>
  {
    public ModelList()
    {
      Add(new Model() { Name = "김나래", Gender = "여", Age = 30 });
      Add(new Model() { Name = "박수홍", Gender = "남", Age = 11 });
      Add(new Model() { Name = "안철수", Gender = "남", Age = 20 });
      Add(new Model() { Name = "김훈수", Gender = "남", Age = 45 });
    }
  }
}
