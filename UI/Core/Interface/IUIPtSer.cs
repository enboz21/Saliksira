using Entity.DTOs;

namespace UI.Core.Interface
{
    internal interface IUIPtSer
    {
        Task<List<PtDTO>> PtListAll();
        void Ptdelete(int ID);
        Task<PtDTO> PtId(int ID);
        void Ptup(PtDTO TEMP);
        void PtPost(PtDTO TEMP);
        Task<string[]> Add(String TC);
    }
}
