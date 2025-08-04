using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess
{
    public class PtSet : DataBaseAc<Hastalar>, IPtSet
    {
        public PtSet(AContext context) : base(context)
        {
        }

        public async Task<Hastalar> GetByTc(string Tc)
        {
            return await _context.Set<Hastalar>()
                         .Where(e => EF.Property<string>(e, "TckimlikNo") == Tc)
                         .Include("Doktor")
                         .Include("Cins")
                         .FirstOrDefaultAsync();
        }
        public async Task<List<Hastalar>> GetAll()
        {
            return await _context.Set<Hastalar>()
                .Include("Cins")
                .Include("Doktor").ToListAsync();
        }

        public Task<List<Hastalar>> GetByName(string Name)
        {
            return _context.Set<Hastalar>()
                .Where(e => EF.Property<string>(e, "Name") == Name)
                .Include("Cins")
                .Include("Doktor")
                .ToListAsync();
        }
    }
}
