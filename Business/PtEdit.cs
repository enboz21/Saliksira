using Core;
using DataAccsess;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Business
{
    public class PtEdit : IEdit<PtDTO>
    {
        private readonly AContext _context;
        public PtEdit(AContext context)
        {
            _context = context;
        }
        public Task<List<PtDTO>> GetAllAp()
        {
            var query = _context.Hastalars
                .Select(p => new PtDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Surname = p.Soyad,
                    TcNo = p.TckimlikNo,
                    BirthDate = p.DogumTarihi,
                    PhoneNumber = p.TelefonNumarasi,
                    Gender = p.Cinsiyet,
                    Address = p.Adres

                }).ToListAsync();
            return query;

        }
    }
}