using Core;
using Entity;
using Entity.DTOs;

namespace Business.@interface
{
    public interface IGeSer : IService<Cin>
    {
        Task<List<GeDTO>> GetAll();
    }
}
