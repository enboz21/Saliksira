using Entity.DTOs;

namespace UI.Core.Interface
{
    internal interface IUIGeSer
    {
        Task<List<GeDTO>> GetAll();
    }
}
