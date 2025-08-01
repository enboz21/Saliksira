using Core;
using DataAccsess.abstrack;
using DataAccsess.Interface;
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
    }
}
