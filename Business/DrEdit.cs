using Core;
using DataAccsess;
using Entity;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DrEdit : IEdit<DrDTO>
    {
        private readonly AContext _context;
        public DrEdit(AContext context)
        {
            _context = context;
        }

        public Task<List<DrDTO>> GetAllAp()
        {
            var query = _context.Doktorlars
                .Select(d => new DrDTO
                {
                    Id = d.Id,
                    Name = d.Name,
                    Surname = d.Soyad,
                    Specialization = d.UzmanlikAlani,
                    PhoneNumber = d.TelefonNumarasi,
                    vailability = d.AktifMi ?? false // AktifMi null ise false olarak varsay
                })
                .ToListAsync();
            return query;
        }
    }
}
