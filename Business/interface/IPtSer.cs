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
    public interface IPtSer : IService<Hastalar>
    {
        Task<List<PtDTO>> GetAll();
        Task<PtDTO> GetByTc(String TC);
        Task<List<PtDTO>> GetByName(String NAME);

        Task<PtDTO> Save(PtDTO DATA);
    }
}
