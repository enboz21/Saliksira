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
    public interface IGeSer : IService<Cin>
    {
        Task<List<GeDTO>> GetAll();
    }
}
