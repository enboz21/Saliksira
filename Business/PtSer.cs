using Business.abstrack;
using Business.@interface;
using Core;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PtSer : ServiceBase<Hastalar>, IPtSer
    {
        private readonly IPtSet _dataSet;
        public PtSer(IPtSet dataSet) : base(dataSet)
        {
            _dataSet = dataSet;
        }

        public async Task<List<PtDTO>> GetAll()
        {
            var TEMP = await _dataSet.GetAll();
            return TEMP.Select(x => new PtDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Soyad,
                TcNo = x.TckimlikNo,
                BirthDate =x.DogumTarihi,
                Gender = x.Cinsiyet,
                Address = x.Adres,
                DrId =x.Doktor.Id,
                DrName =x.Doktor.Name,
                Drsoyad = x.Doktor.Soyad
            }).ToList();
        }

        public async Task<List<PtDTO>> GetByName(string NAME)
        {
            var TEMP = await _dataSet.GetByName(NAME);
            var RET = TEMP.Select(x => new PtDTO
            {
                Name = x.Name,
                Surname = x.Soyad,
                TcNo = x.TckimlikNo,
                BirthDate = x.DogumTarihi,
                Gender = x.Cinsiyet,
                Address = x.Adres,
                DrId = x.Doktor.Id,
                DrName = x.Doktor.Name,
                Drsoyad = x.Doktor.Soyad

            }).ToList();
            return RET;
        }

        public async Task<PtDTO> GetByTc(string TC)
        {
            var TEMP = await _dataSet.GetByTc(TC);
            var RET = new PtDTO
            {
                Name = TEMP.Name,
                Surname = TEMP.Soyad,
                TcNo = TEMP.TckimlikNo,
                BirthDate = TEMP.DogumTarihi,
                Gender = TEMP.Cinsiyet,
                Address = TEMP.Adres,
                DrId = TEMP.Doktor.Id,
                DrName = TEMP.Doktor.Name,
                Drsoyad = TEMP.Doktor.Soyad
            };
            return RET;
        }

        public async Task<PtDTO> Save(PtDTO DATA)
        {
            var TEMP = new Hastalar{
                Name = DATA.Name,
                Soyad = DATA.Surname,
                TckimlikNo = DATA.TcNo,
                DogumTarihi = DATA.BirthDate,
                Cinsiyet = DATA.Gender,
                TelefonNumarasi = DATA.PhoneNumber,
                Adres = DATA.Address,
                Doktorid =DATA.DrId,
            };
            TEMP = await _dataSet.Save(TEMP);
            DATA.Id = TEMP.Id;
            return DATA;

        }
    }
}
