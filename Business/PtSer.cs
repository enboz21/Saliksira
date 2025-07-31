using Core;
using Entity;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PtSer : testCore<Hastalar, PtDTO>
    {
        private readonly IDataSet<Hastalar> _dataSet;

        public PtSer(IDataSet<Hastalar> dataSet)
        {
            _dataSet = dataSet;
        }

        public Task DeleteService(int Id)
        {
            return _dataSet.Delete(Id);
        }

        public async Task<List<PtDTO>> GetAllService()
        {
            var TMP = await _dataSet.GetAll();
            var query = TMP
                .Select(p => new PtDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Surname = p.Soyad,
                    TcNo = p.TckimlikNo,
                    BirthDate = p.DogumTarihi,
                    PhoneNumber = p.TelefonNumarasi,
                    Gender = p.Cinsiyet,
                    Address = p.Adres,
                    DrId = p.Doktorid,
                    DrName = p.Doktor.Name,
                    Drsoyad = p.Doktor.Soyad
                })
                .ToList();

            return query;
        }

        public async Task<Hastalar> GetByIdService(int Id)
        {
            return await _dataSet.GetById(Id);
        }

        public async Task<List<Hastalar>> GetByNameService(string Name)
        {
            return await _dataSet.GetByName(Name);
        }

        public async Task<PtDTO> SaveService(PtDTO Data)
        {
            var TMP = new Hastalar
            {
                Name = Data.Name,
                Soyad = Data.Surname,
                TckimlikNo = Data.TcNo,
                DogumTarihi = Data.BirthDate,
                Cinsiyet = Data.PhoneNumber,
                TelefonNumarasi = Data.PhoneNumber,
                Adres = Data.Address,
                Doktorid = Data.DrId
            };

            var TMP2 = await _dataSet.Save(TMP);
            Data.Id = TMP2.Id;
            return Data;
        }

        public async Task<List<PtDTO>> GetByTcService(string Tc)
        {
            var TMP = await _dataSet.GetByTc(Tc);

            List<PtDTO> query = TMP
                .Select(p => new PtDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Surname = p.Soyad,
                    TcNo = p.TckimlikNo,
                    BirthDate = p.DogumTarihi,
                    PhoneNumber = p.TelefonNumarasi,
                    Gender = p.Cinsiyet,
                    Address = p.Adres,
                    DrId = p.Doktorid,
                    DrName = p.Doktor.Name,
                    Drsoyad = p.Doktor.Soyad
                })
                .ToList();

            return query;
        }
    }
}
