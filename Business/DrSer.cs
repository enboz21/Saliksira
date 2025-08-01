using Business.abstrack;
using Business.@interface;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;
using System;
using System.Data;

namespace Business
{
    public class DrSer : ServiceBase<Doktorlar>, IDrSer
    {
        private readonly IDrSet _dataSet;
        public DrSer(IDrSet dataSet) : base(dataSet)
        {
            _dataSet = dataSet;
        }

        public async Task<List<DrDTO>> GetAll()
        {
            var TEMP = await _dataSet.GetAll();
            var RET = TEMP.Select(x => new DrDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Soyad,
                Specialization = x.UzmanlikAlani,
                PhoneNumber = x.TelefonNumarasi,
                vailability = x.AktifMi

            }).ToList();
            return RET;
        }

        public async Task<List<DrDTO>> GetByName(string name)
        {
            var TEMP = await _dataSet.GetByName(name);
            var RET = TEMP.Select(x => new DrDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Soyad,
                Specialization = x.UzmanlikAlani,
                PhoneNumber = x.TelefonNumarasi,
                vailability = x.AktifMi
            }).ToList();
            return RET;
        }

        public async Task<DrDTO> Save(DrDTO dr)
        {
            var TEMP = new Doktorlar
            {
                Name = dr.Name,
                Soyad = dr.Surname,
                UzmanlikAlani = dr.Specialization,
                TelefonNumarasi = dr.PhoneNumber,
                AktifMi = dr.vailability
            };

            TEMP = await _dataSet.Save(TEMP);
            dr.Id = TEMP.Id;
            return dr;

        }
    }
}
