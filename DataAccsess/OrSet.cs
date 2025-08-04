using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
