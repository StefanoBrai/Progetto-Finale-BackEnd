using ProgettoFinaleBack.Models.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoFinaleBack.Models.Repositories.Implementations
{
    public class EfCrudRepository<T> : CrudRepository<T> where T : class
    {
        protected ProgettoFinaleContext ctx; //si fa iniettare il contesto
        public EfCrudRepository(ProgettoFinaleContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var found = await ctx.Set<T>().FindAsync(id); //.set individua il dbset che voglio 
            if (found == null)
            {
                return false;
            }
            ctx.Set<T>().Remove(found);
            return true;
        }
        public IEnumerable<T> FindAll()
        {
            return ctx.Set<T>();
        }
        public async Task<T> FindByIdAsync(int id)
        {
            return await ctx.Set<T>().FindAsync(id);
        }
        public T Insert(T toInsert) //nn lancio nessuna query quindi nn ha bisogno di essere asincrono
        {
            ctx.Set<T>().Add(toInsert);
            return toInsert;
        }
        public async Task<bool> UpdateAsync(int id, T toUpdate)
        {
            var found = await FindByIdAsync(id);
            if (found == null)
            {
                return false;
            }
            ctx.Set<T>().Update(toUpdate);
            return true;
        }
    }
}
