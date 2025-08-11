using Core;
using Entity;
using Entity.DTOs;

namespace Business.@interface
{
    public interface IOrSer : IService<Randevular>
    {
        Task<OrDTO> Save(OrEDTO DATA);
        Task<List<OrDTOE>> GetAll();
        Task<List<OrDTO>> GetByName(String NAME);
        Task<OrEDTO> GetByHId(int ID);
        Task<List<OrDTOE>> GetByDrID(int drid);

    }
}
