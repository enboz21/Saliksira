using Entity.DTOs;

namespace UI.Core.Interface
{
    internal interface IUIDrSer
    {
        Task<List<DrDTO>> DrListAll();
        void Drdelete(int ID);
        Task<DrDTO> GetDrId(int ID);
        void DrUp(DrDTO TEMP);
        void DrPost(DrDTO TEMP);
    }
}
