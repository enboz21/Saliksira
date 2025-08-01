using Core;
using Entity;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.@interface
{
    public interface IOrSer : IService<Randevular>
    {
        Task<OrDTO> Save(OrEDTO DATA);
        Task<List<OrDTOE>> GetAll();
        Task<List<OrDTO>> GetByName(String NAME);
        
    }
}
