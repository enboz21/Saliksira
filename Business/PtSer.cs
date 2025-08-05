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
                PhoneNumber=x.TelefonNumarasi,
                Genderid = x.Cins.Id,
                Gender = x.Cins.Cinsiyet,
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
                Id = x.Id,
                Name = x.Name,
                Surname = x.Soyad,
                TcNo = x.TckimlikNo,
                BirthDate = x.DogumTarihi,
                Genderid = x.Cins.Id,
                Gender = x.Cins.Cinsiyet,
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
            if (TEMP != null)
            {
                var RET = new PtDTO
                {
                    Id = TEMP.Id,
                    Name = TEMP.Name,
                    Surname = TEMP.Soyad,
                    TcNo = TEMP.TckimlikNo,
                    BirthDate = TEMP.DogumTarihi,
                    Genderid = TEMP.Cins.Id,
                    Gender = TEMP.Cins.Cinsiyet,
                    Address = TEMP.Adres,
                    DrId = TEMP.Doktor.Id,
                    DrName = TEMP.Doktor.Name,
                    Drsoyad = TEMP.Doktor.Soyad
                };
                return RET;
            }
            return null;
        }
            

        public async Task<PtDTO> Save(PtDTO DATA)
        {
            var TEMP = new Hastalar{
                Name = DATA.Name,
                Soyad = DATA.Surname,
                TckimlikNo = DATA.TcNo,
                DogumTarihi = DATA.BirthDate,
                Cinsid = (byte)DATA.Genderid,
                TelefonNumarasi = DATA.PhoneNumber,
                Adres = DATA.Address,
                Doktorid =DATA.DrId,
            };
            TEMP = await _dataSet.Save(TEMP);
            DATA.Id = TEMP.Id;
            return DATA;

        }

        public async Task<PtDTO> Update(PtDTO DATA)
        {
            var TEMP = new Hastalar
            {
                Id = DATA.Id,
                Name = DATA.Name,
                Soyad = DATA.Surname,
                TckimlikNo = DATA.TcNo,
                DogumTarihi = DATA.BirthDate,
                Cinsid = (byte)DATA.Genderid,
                TelefonNumarasi = DATA.PhoneNumber,
                Adres = DATA.Address,
                Doktorid = (byte)DATA.DrId
            };
            TEMP = await _dataSet.Update(TEMP);
            return new PtDTO
            {
                Id = TEMP.Id,
                Name = TEMP.Name,
                Surname = TEMP.Soyad,
                TcNo = TEMP.TckimlikNo,
                BirthDate = TEMP.DogumTarihi,
                Genderid = (int)TEMP.Cinsid,
                PhoneNumber = TEMP.TelefonNumarasi,
                Address = TEMP.Adres,
                DrId = TEMP.Doktorid
            };
        }
    }
}
