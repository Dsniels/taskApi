using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class Usuario : ClaseBase
{
    public string Name { get; set; }
    public string Apellido { get; set;}
    public List<Tasks> Tareas {get; set; }


}
