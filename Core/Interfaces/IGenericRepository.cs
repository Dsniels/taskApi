using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : ClaseBase
{
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<int> add(T entity);

    Task<int> update(T entity);

    void AddEntity(T entity);

    void updateEntity(T entity);
    void DeleteEntity(T entity);


}
