using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlP.MyCommand
{
  public class Emp
  {
    public string Name { get; set; } = "";
    public string Job { get; set; } = "";
    public override string ToString()
    {
      return $"{Name} {Job}";
    }

  }
}
