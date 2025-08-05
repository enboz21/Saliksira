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
    public interface IDrSer : IService<Doktorlar>
    {
        Task<List<DrDTO>> GetAll();
        Task<List<DrDTO>> GetByName(string name);
        Task<DrDTO> Save(DrDTO dr);
        Task<DrDTO> Update(DrDTO dr);
        Task<List<DrDTO>> GetByVa();
    }
}
