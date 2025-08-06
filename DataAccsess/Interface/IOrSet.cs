using Core;
using Entity;

namespace DataAccsess.Interface
{
    public interface IOrSet : IDataSet<Randevular>
    {
        Task<List<Randevular>> GetAll();
        Task<List<Randevular>> GetByName(string name);
        Task<Randevular> GetByHId(int hId);
    }
}
