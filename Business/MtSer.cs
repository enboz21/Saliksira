using Core;
using Entity.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MtSer : testCore<Durum, MtDTO>
    {
        private readonly IDataSet<Durum> _dataSet;

        public MtSer(IDataSet<Durum> dataSet)
        {
            _dataSet = dataSet;
        }

        public Task DeleteService(int Id)
        {
            return _dataSet.Delete(Id);
        }

        public async Task<List<MtDTO>> GetAllService()
        {
            var TMP = await _dataSet.GetAll();
            var query = TMP
                .Select(p => new MtDTO
                {
                    Id = p.Id,
                    Durum = p.Durum1
                })
                .ToList();

            return query;
        }

        public async Task<Durum> GetByIdService(int Id)
        {
            return await _dataSet.GetById(Id);
        }

        public async Task<List<Durum>> GetByNameService(string Name)
        {
            return await _dataSet.GetByName(Name);
        }

        public Task<List<Durum>> GetByTcService(string Tc)
        {
            throw new NotImplementedException();
        }

        public async Task<MtDTO> SaveService(MtDTO Data)
        {
            var TMP = new Durum
            {
                Durum1 = Data.Durum
            };

            var TMP2 = await _dataSet.Save(TMP);
            Data.Id = TMP2.Id;
            return Data;
        }
    }
}
