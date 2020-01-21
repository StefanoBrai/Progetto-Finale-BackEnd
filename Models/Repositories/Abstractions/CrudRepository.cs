using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoFinaleBack.Models.Repositories.Abstractions
{    public interface CrudRepository<T> where T : class //restrizione imposta dal dbset che lavora con i ref type
    {
        Task<T> FindByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
        T Insert(T toInsert);
        Task<bool> UpdateAsync(int id, T toUpdate);
        IEnumerable<T> FindAll();
    }
}