using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using BusinessLogic.Data;

namespace BusinessLogic;

public class TareasRepository : ITareasRepository
{
    private readonly TaskDbContext _context;

    public TareasRepository(TaskDbContext context){
        _context = context;
    }



    public async Task<IReadOnlyList<Tasks>> GetAllAsync()
    {
        return await _context.Tasks.ToListAsync();
    }

    public async Task<Tasks> GetTaskAsync(int id)
    {
        return await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);
    }
}
