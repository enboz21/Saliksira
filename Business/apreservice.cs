// Business katmanında, RandevuRaporServisi veya benzeri bir isimde
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; // ToListAsync ve Include için
using DataAccsess; // AContext için
using Entity.DTOs; // RandevuBasitRaporDto için
using Entity;
using Core; // Randevular, Doktorlar, Hastalar, Durum için

namespace Business
{
    public class apreservice : IEdit<ApDto>
    {
        private readonly AContext _context;

        public apreservice(AContext context)
        {
            _context = context;
        }

        // Randevular için özel rapor metodu
        public async Task<List<ApDto>> GetAllAp()
        {
            var query = await _context.Randevulars
                                .Include(r => r.Hasta) // Hastalar navigasyon property'sini dahil et
                                .Include(r => r.Doktor) // Doktorlar navigasyon property'sini dahil et
                                .Include(r => r.RandevuDurumuNavigation) // Durum navigasyon property'sini dahil et
                                .Select(r => new ApDto
                                {
                                    RandevuId = r.Id,
                                    HastaAdi = r.Hasta.Name,
                                    HastaSoyadi = r.Hasta.Soyad,
                                    DoktorAdi = r.Doktor.Name,
                                    DoktorSoyadi = r.Doktor.Soyad,
                                    RandevuDurumu = r.RandevuDurumuNavigation.Durum1 // Durum nesnesinin ID'si
                                })
                                .ToListAsync();

            return query;
        }
    }
}