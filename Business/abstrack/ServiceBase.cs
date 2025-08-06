using Core;

namespace Business.abstrack
{
    public abstract class ServiceBase<T> : IService<T> where T : class
    {
        internal readonly IDataSet<T> _dataSet;

        public ServiceBase(IDataSet<T> dataSet)
        {
            _dataSet = dataSet;
        }

        public Task DeleteService(int Id)
        {
            return _dataSet.Delete(Id);
        }

        public async Task<T> GetByIdService(int Id)
        {
            return await _dataSet.GetById(Id);
        }
    }
}
