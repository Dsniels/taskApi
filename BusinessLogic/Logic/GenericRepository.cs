using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Security.Cryptography.X509Certificates;
using BusinessLogic.Data;

namespace BusinessLogic.Logic;

public class GenericRepository<T> : IGenericRepository<T> where T : ClaseBase
{
    private readonly TaskDbContext _context;

    public GenericRepository(TaskDbContext context)
    {
        _context = context;
    }

    public async Task<int> add(T entity)
    {
        _context.Set<T>().Add(entity);

        return await _context.SaveChangesAsync();
    }

    public void AddEntity(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void DeleteEntity(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<int> update(T entity)
    {
        _context.Set<T>().Attach(entity);
        return await _context.SaveChangesAsync();
    }

    public void updateEntity(T entity)
    {
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
}
