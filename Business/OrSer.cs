using Core;
using Entity;
using Entity.DTOs;
using System;
using System.Linq;

namespace Business
{
    public class OrSer : testCore<Randevular, OrDTO>
    {
        private readonly IDataSet<Randevular> _dataSet;
        public OrSer(IDataSet<Randevular> dataSet)
        {
            _dataSet = dataSet;
        }

        public Task DeleteService(int Id)
        {
            return _dataSet.Delete(Id);
        }

        public async Task<List<OrDTO>> GetAllService()
        {
            var TMP = await _dataSet.GetAll();
            var query = TMP
                .Select(o => new OrDTO
                {
                    Id = o.Id,
                    HastaAdi = o.Hasta.Name,
                    HastaSoyadi = o.Hasta.Soyad,
                    DoktorAdi = o.Doktor.Name,
                    DoktorSoyadi = o.Doktor.Soyad,
                    RandevuDurumu = o.RandevuDurumuNavigation.Durum1
                })
                .ToList();
            return query;
        }

        public async Task<Randevular> GetByIdService(int Id)
        {
            return await _dataSet.GetById(Id);
        }

        public async Task<List<Randevular>> GetByNameService(string Name)
        {
            return await _dataSet.GetByName(Name);
        }

        public Task<List<OrDTO>> GetByTcService(string Tc)
        {
            throw new NotImplementedException();
        }

        public async Task<OrDTO> SaveService(OrDTO Data)
        {
            var TMP = new Randevular
            {
                HastaId = Data.HastaId,
                DoktorId = Data.DoktorId,
                RandevuDurumu = Data.RandevuDurumuId
            };

            var TMP2 = await _dataSet.Save(TMP);
            Data.Id = TMP2.Id;
            return Data;

        }
    }
}
