using Business.abstrack;
using Business.@interface;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;

namespace Business
{
    public class OrSer : ServiceBase<Randevular>, IOrSer
    {
        private readonly IOrSet _dataSet;

        public OrSer(IOrSet dataSet) : base(dataSet)
        {
            _dataSet = dataSet;
        }

        public async Task<List<OrDTOE>> GetAll()
        {
            var TEMP = await _dataSet.GetAll();
            return TEMP.Select(x => new OrDTOE
            {
                Id = x.Id,
                HastaAdi = x.Hasta.Name,
                HastaSoyadi = x.Hasta.Soyad,
                DoktorAdi = x.Doktor.Name,
                DoktorSoyadi = x.Doktor.Soyad,
                RandevuDurumu = x.RandevuDurumuNavigation.Durum1
            }).ToList();
        }

        public async Task<OrEDTO> GetByHId(int ID)
        {
            var TEMP = await _dataSet.GetByHId(Convert.ToInt32(ID));
            if (TEMP != null)
            {
                return new OrEDTO
                {
                    HastaId = TEMP.HastaId,
                    DoktorId = TEMP.DoktorId
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<List<OrDTO>> GetByName(string NAME)
        {
            var TEMP = await _dataSet.GetByName(NAME);
            return TEMP.Select(x => new OrDTO
            {
                Id = x.Id,
                HastaId = x.HastaId,
                DoktorId = x.DoktorId,
                RandevuDurumuId = x.RandevuDurumu,
                HastaAdi = x.Hasta.Name,
                HastaSoyadi = x.Hasta.Soyad,
                DoktorAdi = x.Doktor.Name,
                DoktorSoyadi = x.Doktor.Soyad,
                RandevuDurumu = x.RandevuDurumuNavigation.Durum1
            }).ToList();
        }

        public async Task<OrDTO> Save(OrEDTO DATA)
        {
            var TEMP = new Randevular
            {
                DoktorId = DATA.DoktorId,
                HastaId = (int)DATA.HastaId,
                RandevuDurumu = (byte)1
            };

            TEMP = await _dataSet.Save(TEMP);
            return new OrDTO
            {
                Id = TEMP.Id,
                HastaId = TEMP.HastaId,
                DoktorId = TEMP.DoktorId,
                RandevuDurumuId = TEMP.RandevuDurumu
            };


        }
    }
}
