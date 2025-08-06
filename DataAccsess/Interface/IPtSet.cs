using Core;
using Entity;

namespace DataAccsess.Interface
{
    public interface IPtSet : IDataSet<Hastalar>
    {
        Task<Hastalar> GetByTc(String Tc);
        Task<List<Hastalar>> GetAll();
        Task<List<Hastalar>> GetByName(string Name);
    }
}
