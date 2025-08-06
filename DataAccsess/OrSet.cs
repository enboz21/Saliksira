using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess
{
    public class OrSet : DataBaseAc<Randevular>, IOrSet
    {
        public OrSet(AContext context) : base(context)
        {
        }

        public async Task<List<Randevular>> GetAll()
        {
            return await _context.Set<Randevular>()
                    .Include("Hasta")
                    .Include("Doktor")
                    .Include("RandevuDurumuNavigation")
                    .ToListAsync();
        }

        public async Task<Randevular> GetByHId(int hId)
        {
            return await _context.Set<Randevular>()
                .FirstOrDefaultAsync(e => EF.Property<int>(e, "HastaId") == hId);
        }

        public async Task<List<Randevular>> GetByName(string name)
        {
            return await _context.Set<Randevular>()
                    .Include("Hasta")
                    .Include("Doktor")
                    .Include("RandevuDurumuNavigation")
                    .Where(e => EF.Property<string>(e, "Name") == name)
                    .ToListAsync();
        }


    }
}
