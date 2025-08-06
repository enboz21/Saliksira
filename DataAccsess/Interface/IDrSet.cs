using Core;
using Entity;

namespace DataAccsess.Interface
{
    public interface IDrSet : IDataSet<Doktorlar>
    {
        Task<List<Doktorlar>> GetByName(string Name);
        Task<List<Doktorlar>> GetByVa();
    }
}
