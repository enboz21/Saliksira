using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess
{
    public class DrSet : DataBaseAc<Doktorlar>, IDrSet
    {
        public DrSet(AContext context) : base(context)
        {
        }

        public Task<List<Doktorlar>> GetByName(string Name)
        {
            return _context.Set<Doktorlar>()
                .Where(e => EF.Property<string>(e, "Name") == Name)
                .ToListAsync();
        }

        public Task<List<Doktorlar>> GetByVa()
        {
            return _context.Set<Doktorlar>()
                .Where(e => EF.Property<bool>(e, "AktifMi") == true)
                .ToListAsync();
        }
    }
}
