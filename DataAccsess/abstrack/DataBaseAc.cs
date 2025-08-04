using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccsess.abstrack
{
    public abstract class DataBaseAc<T> : IDataSet<T> where T : class, IEntity, new()
    {
        internal readonly AContext _context;

        public DataBaseAc(AContext context)
        {
            _context = context;
        }

        public async Task Delete(int Id)
        {
            await _context.Set<T>()
                .Where(e => EF.Property<int>(e, "Id") == Id) // Assuming the entity has an Id property
                .ExecuteDeleteAsync();
        }

        public async Task<List<T>> GetAll()
        {
                return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetById(int Id)
        {
            return _context.Set<T>()
                .FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == Id);
        }

        public async Task<T> Save(T Data)
        {
            await _context.Set<T>().AddAsync(Data);
            await _context.SaveChangesAsync();
            return Data;
        }

        public async Task<T> Update(T Data)
        {
            _context.Set<T>().Update(Data);
            await _context.SaveChangesAsync();
            return Data;
        }
    }
}
