using Core;
using Entity;
using Entity.DTOs;

namespace Business.@interface
{
    public interface IDrSer : IService<Doktorlar>
    {
        Task<List<DrDTO>> GetAll();
        Task<List<DrDTO>> GetByName(string name);
        Task<DrDTO> Save(DrDTO dr);
        Task<DrDTO> Update(DrDTO dr);
        Task<List<DrDTO>> GetByVa();
    }
}
