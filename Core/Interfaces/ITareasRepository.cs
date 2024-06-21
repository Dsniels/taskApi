using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Interfaces;

public interface ITareasRepository
{
    Task<Tasks> GetTaskAsync(int id);
    Task<IReadOnlyList<Tasks>> GetAllAsync();
    
    
}
