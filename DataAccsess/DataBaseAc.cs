using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccsess
{
    public class DataBaseAc<T> : IDataSet<T> where T : class
    {
        private readonly AContext _context;

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

            if (typeof(T)==typeof(Randevular)) 
            {
                return await _context.Set<T>()
                    .Include("Hasta") // Assuming the entity has a navigation property named "Hasta"
                    .Include("Doktor") // Assuming the entity has a navigation property named "Doktor"
                    .Include("RandevuDurumuNavigation") // Assuming the entity has a navigation property named "RandevuDurumuNavigation"
                    .ToListAsync();
            }
            else if (typeof(T) == typeof(Hastalar))
            {
                return await _context.Set<T>()
                    .Include("Doktor").ToListAsync();
            }


                return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetById(int Id)
        {
            return _context.Set<T>()
                .FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == Id);
        }

        public Task<List<T>> GetByName(string Name)
        {
            return _context.Set<T>()
                .Where(e => EF.Property<string>(e, "Name") == Name) // Assuming the entity has a Name property
                .ToListAsync();
        }

        public Task<List<T>> GetByTc(String Tc)
        {
            return _context.Set<T>()
                .Where(e => EF.Property<string>(e, "TckimlikNo") == Tc) // Assuming the entity has a Name property
                .ToListAsync();
        }

        public async Task<T> Save(T Data)
        {
            await _context.Set<T>().AddAsync(Data);
            await _context.SaveChangesAsync();
            return Data;
        }
    }
}
