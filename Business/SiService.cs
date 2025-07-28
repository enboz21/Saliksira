using Core;
using DataAccsess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SiService : IDataSer<Randevular>
    {
        private readonly IDataSet<Randevular> _dataBaseAc;
        public SiService(IDataSet<Randevular> dataBaseAc)
        {
            _dataBaseAc = dataBaseAc;
        }

        public Task DeleteService(int Id)
        {
            return _dataBaseAc.Delete(Id);
        }

        public Task<List<Randevular>> GetAllService()
        {
            throw new NotImplementedException();
        }

        public async Task<Randevular> GetByIdService(int Id)
        {
            return await _dataBaseAc.GetById(Id);
        }

        public Task<List<Randevular>> GetByNameService(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<Randevular> SaveService(Randevular Data)
        {
            Data = new SiCreat().Create(Data);
            return await _dataBaseAc.Save(Data);
        }
    }
}
