using Core;
using DataAccsess;
using Entity;

namespace Business
{
    public class DataService<T> : IDataSer<T> where T : class
    {
        private readonly IDataSet<T> _dataBaseAc;
        public DataService(IDataSet<T> dataBaseAc)
        {
            _dataBaseAc = dataBaseAc;
        }

        public Task DeleteService(int Id)
        {
            return _dataBaseAc.Delete(Id);
        }

        public async Task<List<T>> GetAllService()
        {
            

           return await _dataBaseAc.GetAll();
        }

        public async Task<T> GetByIdService(int Id)
        {
            return await _dataBaseAc.GetById(Id);
        }

        public async Task<List<T>> GetByNameService(string Name)
        {
            return await _dataBaseAc.GetByName(Name);
        }

        public async Task<T> SaveService(T Data)
        {

            return await _dataBaseAc.Save(Data);

        }
    }
}
