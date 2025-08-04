using Core;
using Entity;
using Entity.DTOs;

namespace Business.@interface
{
    public interface IPtSer : IService<Hastalar>
    {
        Task<List<PtDTO>> GetAll();
        Task<PtDTO> GetByTc(String TC);
        Task<List<PtDTO>> GetByName(String NAME);

        Task<PtDTO> Save(PtDTO DATA);
        Task<PtDTO> Update(PtDTO DATA);
    }
}
