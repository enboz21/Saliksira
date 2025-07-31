using Core;
using DataAccsess;
using Entity;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DrSer : testCore<Doktorlar,DrDTO>
    {
        private readonly IDataSet<Doktorlar> _dataSet;

        public DrSer(IDataSet<Doktorlar> dataSet)
        {
            _dataSet = dataSet;
        }

        public Task DeleteService(int Id)
        {
            return _dataSet.Delete(Id);
        }

        public async Task<List<DrDTO>> GetAllService()
        {
            var Dr= await _dataSet.GetAll();
            var query = Dr
                .Select(d => new DrDTO
                {
                    Id = d.Id,
                    Name = d.Name,
                    Surname = d.Soyad,
                    Specialization = d.UzmanlikAlani,
                    PhoneNumber = d.TelefonNumarasi,
                    vailability = d.AktifMi ?? false // AktifMi null ise false olarak varsay
                })
                .ToList();

            return query;
        }

        public async Task<Doktorlar> GetByIdService(int Id)
        {
            return await _dataSet.GetById(Id);
        }

        public async Task<List<Doktorlar>> GetByNameService(string Name)
        {
            return await _dataSet.GetByName(Name);
        }

        public Task<List<DrDTO>> GetByTcService(string Tc)
        {
            throw new NotImplementedException();
        }

        public async Task<DrDTO> SaveService(DrDTO Data)
        {
            var dr= new Doktorlar
            {
                Name = Data.Name,
                Soyad = Data.Surname,
                UzmanlikAlani = Data.Specialization,
                TelefonNumarasi = Data.PhoneNumber,
                AktifMi = Data.vailability
            };

            var dr2= await _dataSet.Save(dr);
            Data.Id = dr2.Id;
            return Data;

        }
    }
}
