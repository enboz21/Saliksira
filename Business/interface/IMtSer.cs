using Core;
using Entity;
using Entity.DTOs;

namespace Business.@interface
{
    public interface IMtSer : IService<Durum>
    {
        Task<List<MtDTO>> GetAll();
        Task<MtDTO> Save(MtDTO DATA);
    }
}
