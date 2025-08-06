using Business.abstrack;
using Business.@interface;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;

namespace Business
{
    public class MtSer : ServiceBase<Durum>, IMtSer
    {
        private readonly IMtSet _dataSet;
        public MtSer(IMtSet dataSet) : base(dataSet)
        {
            _dataSet = dataSet;
        }

        public async Task<List<MtDTO>> GetAll()
        {
            var TEMP = await _dataSet.GetAll();
            return TEMP.Select(x => new MtDTO
            {
                Id = x.Id,
                Durum = x.Durum1
            }).ToList();
        }

        public async Task<MtDTO> Save(MtDTO DATA)
        {
            var TEMP = new Durum
            {
                Id = DATA.Id,
                Durum1 = DATA.Durum
            };
            TEMP = await _dataSet.Save(TEMP);
            DATA.Id = TEMP.Id;
            return DATA;
        }
    }
}
