
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Tasks : ClaseBase
{
    
    public string Titulo {get; set;}

    public string Tarea {get; set; }

    public DateTimeOffset Date {get; set; }

    public bool Status {get; set; }


}
